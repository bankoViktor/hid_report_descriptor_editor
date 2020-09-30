using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.ListViewItem;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class MainForm : Form
    {
        private readonly Color NumberColor = Color.FromArgb(0xFF8000);
        private readonly Color CommentColor = Color.FromArgb(0x008000);

        private bool _isModified;

        private HIDReportItemCollection ReportItems { get; set; }
        private string Filename { get; set; }
        private bool IsNewFile { get; set; }
        private bool IsModified
        {
            get
            {
                return _isModified;
            }
            set
            {
                _isModified = value;
                Text = $"{Application.ProductName} - [{(IsModified ? "*" : "")}{Filename}]";
            }
        }
        public static XmlSerializer Serializer { get; } = new XmlSerializer(typeof(HIDReportItemCollection));

        #region Constructors

        public MainForm(string filename)
        {
            Initialize();
            IsNewFile = false;
            OpenFile(filename);
            EnableUpdate();
        }

        public MainForm()
        {
            Initialize();
            IsNewFile = true;
            CreateFile($"unnamed{Program.FileExtension}");
            EnableUpdate();
        }

        private void Initialize()
        {
            InitializeComponent();
            ListPaletteItems.DoubleBuffering(true);
            ListReportItems.DoubleBuffering(true);
            ListPaletteItems.Groups.AddRange(GroupCollection);
            ListPaletteItems.Items.AddRange(HIDReportHeader.ShortItemHeaders
                .Select(item => new ListViewItem(item.ToString(), GetLVGroup(item.Type)) { Tag = item })
                .ToArray());
        }

        #endregion

        #region List View Group

        private static readonly ListViewGroup[] GroupCollection =
        {
            new ListViewGroup("Main"),
            new ListViewGroup("Global"),
            new ListViewGroup("Local"),
        };

        private ListViewGroup GetLVGroup(ItemType type)
        {
            return type switch
            {
                ItemType.Main => GroupCollection[0],
                ItemType.Global => GroupCollection[1],
                ItemType.Local => GroupCollection[2],
                _ => null,
            };
        }

        #endregion

        #region File Operations

        private void CreateFile(string filename)
        {
            Filename = filename;
            ReportItems = new HIDReportItemCollection();
            IsModified = false;
            IsNewFile = true;
        }

        private void OpenFile(string filename)
        {
            var reports = Open(filename);
            if (reports != null)
            {
                ReportItems = reports;
                Filename = filename;
            }
            else
            {
                ReportItems = new HIDReportItemCollection();
            }
            IsModified = false;
            UpdateListView();
        }

        public static HIDReportItemCollection Open(string filename)
        {
            using var file = File.OpenRead(filename);
            try
            {
                return Serializer.Deserialize(file) as HIDReportItemCollection;
            }
            catch (Exception)
            {
                MessageBox.Show("This file format is not supported.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static void Save(string filename, HIDReportItemCollection items)
        {
            using var file = File.Open(filename, FileMode.Create);
            Serializer.Serialize(file, items);
        }

        #endregion

        private bool ShowEditDialog(ShortItem reportItem)
        {
            var result = false;

            if (DoDialog(reportItem, out IDialogValue dlg))
            {
                if (dlg != null)
                {
                    dlg.Value = reportItem.Value;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        reportItem.Value = dlg.Value;
                        result = true;
                    }
                }
                else
                {
                    reportItem.Value = null;
                    result = true;
                }
            }

            return result;
        }

        private bool DoDialog(ShortItem reportItem, out IDialogValue dlg)
        {
            dlg = null;

            switch (reportItem.Header.Type)
            {
                case ItemType.Main:
                    var tagMain = (ItemTagMain)reportItem.Header.Tag;
                    switch (tagMain)
                    {
                        case ItemTagMain.Collection:
                            dlg = new CollectionForm() { Text = EnumHelper.GetEnumDescription(tagMain) };
                            return true;

                        case ItemTagMain.Input:
                        case ItemTagMain.Output:
                        case ItemTagMain.Feature:
                            dlg = new InputForm(tagMain) { Text = EnumHelper.GetEnumDescription(tagMain) };
                            return true;

                        case ItemTagMain.EndCollection:
                            var originItem = ListReportItems.Items.Count;
                            if (ReportItems.GetOpenCollectionCount(originItem) == 0)
                            {
                                MessageBox.Show("Not matching Collection statrt.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            return true;
                    }
                    break;

                case ItemType.Global:
                    var tagGlobal = (ItemTagGlobal)reportItem.Header.Tag;
                    switch (tagGlobal)
                    {
                        case ItemTagGlobal.UsagePage:
                            dlg = new SelectUsagePageForm() { Text = EnumHelper.GetEnumDescription(tagGlobal) };
                            return true;

                        case ItemTagGlobal.LogicalMinimum:
                        case ItemTagGlobal.LogicalMaximum:
                        case ItemTagGlobal.PhysicalMinimum:
                        case ItemTagGlobal.PhysicalMaximum:
                        case ItemTagGlobal.ReportSize:
                        case ItemTagGlobal.ReportCount:
                            dlg = new NumberInputForm(0x00000000, 0xFFFFFFFF) { Text = EnumHelper.GetEnumDescription(tagGlobal) };
                            return true;

                        case ItemTagGlobal.UnitExponent:
                        case ItemTagGlobal.Unit:
                            MessageBox.Show("Not Implemented.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                        case ItemTagGlobal.ReportID: // 1 byte
                            dlg = new NumberInputForm(0x00, 0xFF) { Text = EnumHelper.GetEnumDescription(tagGlobal) };
                            return true;

                        case ItemTagGlobal.Push:
                        case ItemTagGlobal.Pop:
                            return true;
                    }
                    break;

                case ItemType.Local:
                    var tagLocal = (ItemTagLocal)reportItem.Header.Tag;
                    switch (tagLocal)
                    {
                        case ItemTagLocal.Usage:
                        case ItemTagLocal.UsageMinimum:
                        case ItemTagLocal.UsageMaximum:
                            var originIndex = ListReportItems.SelectedItems.Count > 0
                                ? ListReportItems.SelectedItems.Cast<ListViewItem>().Max(i => i.Index)
                                : ReportItems.Count;
                            var topUsagePage = ReportItems.GetTopUsagePage(originIndex);
                            if (topUsagePage.HasValue)
                            {
                                var upType = topUsagePage.GetAttributeOfType<UsagePageAttribute>()?.UsageType;
                                if (upType != null)
                                {
                                    var usagePageName = EnumHelper.GetEnumDescription(topUsagePage);
                                    dlg = new SelectUsageForm(upType)
                                    {
                                        Text = string.Format("{0} from {1} (0x{2:X4})",
                                            EnumHelper.GetEnumDescription(tagLocal), usagePageName, (int)topUsagePage),
                                    };
                                    return true;
                                }
                                else
                                    MessageBox.Show($"A set Usages for Usage Page \"{EnumHelper.GetEnumDescription(topUsagePage.Value)}\" don't defined.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("You must define a Usage Page before selecting a Usage.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;

                        case ItemTagLocal.DesignatorIndex:
                        case ItemTagLocal.DesignatorMinimum:
                        case ItemTagLocal.DesignatorMaximum:
                        case ItemTagLocal.StringIndex:
                        case ItemTagLocal.StringMinimum:
                        case ItemTagLocal.StringMaximum:
                            dlg = new NumberInputForm(0x00000000, 0xFFFFFFFF) { Text = EnumHelper.GetEnumDescription(tagLocal) };
                            return true;

                        case ItemTagLocal.Delimiter:
                            dlg = new DelimeterForm() { Text = EnumHelper.GetEnumDescription(tagLocal) };
                            return true;
                    }
                    break;
            }

            return false;
        }

        private void UpdateListView()
        {
            // Сохраняем выделенные элементы
            var selected = ListReportItems.SelectedItems
                .Cast<ListViewItem>()
                .Select(lvi => lvi.Tag as HIDReportItem)
                .ToArray();

            // Обновляем
            ListReportItems.Items.Clear();
            ListReportItems.Items.AddRange(ReportItems
                .Select(item => new ListViewItem(new ListViewSubItem[]
                {
                    new ListViewSubItem(null, item.ToString(ReportItems)),
                    new ListViewSubItem(null, item.BytesString) { ForeColor = NumberColor },
                    new ListViewSubItem(null, !string.IsNullOrWhiteSpace(item.Comment)
                        ? $"; {item.Comment}"
                        : string.Empty) { ForeColor = CommentColor },
                }, -1)
                { Tag = item, UseItemStyleForSubItems = false })
                .ToArray());

            // Востанавливаем выделенные элементы
            selected
                .ToList()
                .ForEach(item =>
                {
                    var lvi = ListReportItems.Items
                    .Cast<ListViewItem>()
                    .Where(lvi => lvi.Tag as HIDReportItem == item)
                    .SingleOrDefault();

                    if (lvi != null && ListReportItems.Items.Contains(lvi))
                    {
                        lvi.Selected = true;
                        lvi.Focused = true;
                    }
                });

            // Обновляем состояние кнопок
            EnableUpdate();
        }

        private void EnableUpdate()
        {
            var isSelMoreOne = ListReportItems.SelectedItems.Count > 0;
            var isHasMoreOne = ListReportItems.Items.Count > 0;
            // File
            SmFileSave.Enabled = isHasMoreOne && IsModified;
            SmFileSaveAs.Enabled = isHasMoreOne;
            SmFileExport.Enabled = isHasMoreOne;
            // Edit
            SmEditComment.Enabled = isSelMoreOne;
            SmEditCut.Enabled = isSelMoreOne;
            SmEditCopy.Enabled = isSelMoreOne;
            SmEditPaste.Enabled = true; // TODO имеется вырезанные/скопированные элементы
            SmEditDelete.Enabled = isSelMoreOne;
            SmEditDeleteAll.Enabled = isHasMoreOne;
            SmEditSelectAll.Enabled = isHasMoreOne;
            // View
            SmViewStatusBar.Checked = isHasMoreOne;
            SmViewReportScheme.Checked = false; // TODO доделать структуру репорта

            StatusBarElementCount.Text = $"Count: {ReportItems.Count}";
            StatusBarByteCount.Text = $"{ReportItems.Sum(item => item.GetBytes().Length)} bytes";
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            });
        }

        #region Events

        private void ListReportItems_DoubleClick(object sender, EventArgs e)
        {
            if (ListReportItems.SelectedItems.Count == 1)
            {
                var tag = ListReportItems.SelectedItems[0].Tag;
                if (tag is ShortItem shortItem)
                {
                    if (ShowEditDialog(shortItem))
                    {
                        IsModified = true;
                        UpdateListView();
                    }
                }
                else if (tag is LongItem longItem)
                {
                    var dlg = new HexEditorForm()
                    {
                        Value = longItem.Value
                    };

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        longItem.Value = dlg.Value;

                        IsModified = true;
                    }

                    UpdateListView();
                }
                else
                    throw new NotSupportedException();
            }
        }

        private void ListPaletteItems_DoubleClick(object sender, EventArgs e)
        {
            if (ListPaletteItems.SelectedItems.Count == 1)
            {
                if (ListPaletteItems.SelectedItems[0].Tag is HIDReportHeader reportHeader)
                {
                    var newReportItem = new ShortItem() { Header = reportHeader };
                    if (ShowEditDialog(newReportItem))
                    {
                        IsModified = true;
                        ReportItems.Add(newReportItem);
                        UpdateListView();
                    }
                }
                else
                    throw new NotSupportedException();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified)
            {
                var ret = MessageBox.Show($"File has been modidied! Do you want to save it?", Application.ProductName,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (ret)
                {
                    case DialogResult.Yes:
                        SmFileSave_Click(null, EventArgs.Empty);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableUpdate();
        }

        #endregion

        #region Commands

        private void SmFileSaveAs_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = "Save As ...",
                Filter = $"{Program.FileExtensionCaption} (*{Program.FileExtension})|*{Program.FileExtension}",
                InitialDirectory = Path.GetDirectoryName(Filename),
                FileName = Path.GetFileName(Filename),
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Save(dlg.FileName, ReportItems);
                Filename = dlg.FileName;
                IsModified = false;
            }
        }

        private void SmFileOpen_Click(object sender, EventArgs e)
        {
            var args = new FormClosingEventArgs(CloseReason.UserClosing, false);
            MainForm_FormClosing(null, args);
            if (!args.Cancel)
            {
                var dlg = new OpenFileDialog()
                {
                    Title = "Open File",
                    Filter = $"{Program.FileExtensionCaption} (*{Program.FileExtension})|*{Program.FileExtension}",
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    OpenFile(dlg.FileName);
                    IsNewFile = false;
                }
            }
        }

        private void SmFileExport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            var dlg = new SaveFileDialog()
            {
                Title = "Export to C Header file",
                Filter = "C Header files (*.h)|*.h",
                InitialDirectory = Path.GetDirectoryName(Filename),
                FileName = Path.GetFileNameWithoutExtension(Filename) + ".h",
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Program.Export(ReportItems, dlg.FileName);
            }
            */
        }

        private void SmFileSave_Click(object sender, EventArgs e)
        {
            if (IsNewFile)
            {
                SmFileSaveAs_Click(null, EventArgs.Empty);
                IsNewFile = false;
            }
            else
            {
                Save(Filename, ReportItems);
                IsModified = false;
            }
        }

        private void SmEditDelete_Click(object sender, EventArgs e)
        {
            UpdateListView();

            if (ListReportItems.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in ListReportItems.SelectedItems)
                {
                    var reportItems = lvi.Tag as ShortItem;
                    ReportItems.Remove(reportItems);
                }
                IsModified = true;
                UpdateListView();
            }
        }

        private void SmEditDeleteAll_Click(object sender, EventArgs e)
        {
            ReportItems.Clear();
            IsModified = true;
            UpdateListView();
        }

        private void SmEditSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListReportItems.Items)
            {
                item.Selected = true;
                item.Focused = true;
            }
        }

        private void SmEditComment_Click(object sender, EventArgs e)
        {
            if (ListReportItems.SelectedItems.Count == 1)
            {
                if (ListReportItems.SelectedItems[0].Tag is ShortItem reportItem)
                {
                    var dlg = new CommentForm() { Comment = reportItem.Comment };

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        reportItem.Comment = string.IsNullOrWhiteSpace(dlg.Comment) ? null : dlg.Comment;
                        IsModified = true;
                        UpdateListView();
                    }
                }
            }
        }

        private void SmHelpAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void SmHelpHIDSpec_Click(object sender, EventArgs e)
        {
            const string url = "https://www.usb.org/sites/default/files/hid1_11.pdf";
            OpenUrl(url);
        }

        private void SmHelpHIDUsages_Click(object sender, EventArgs e)
        {
            const string url = "https://www.usb.org/sites/default/files/documents/hut1_12v2.pdf";
            OpenUrl(url);
        }

        private void SmToolsRegisterFileExt_Click(object sender, EventArgs e)
        {
            FileExtensionApplication.Register();
        }

        private void SmToolsUnregisterFileExt_Click(object sender, EventArgs e)
        {
            FileExtensionApplication.Unregister();
        }

        #endregion

        private void BtnAddLongItem_Click(object sender, EventArgs e)
        {
            var longItem = new LongItem();
            var dlg = new HexEditorForm();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                longItem.Value = dlg.Value;
                ReportItems.Add(longItem);
                IsModified = true;
            }

            UpdateListView();
        }
    }
}