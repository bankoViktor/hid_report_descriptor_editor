using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Properties;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Collections.Generic;
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
            CreateFile(Resources.MainForm_UnnamedFile + Program.FileExtension);
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

            // Localize
            ColumnItem.Text = Resources.MainForm_ColumnItem;
            ColumnHex.Text = Resources.MainForm_ColumnHex;
            СolumnComment.Text = Resources.MainForm_ColumnComment;
            BtnAddLongItem.Text = Resources.MainForm_AddLongItem;
            SmFile.Text = Resources.MainForm_MiFile;
            SmFileOpen.Text = Resources.MainForm_MiFileOpen;
            SmFileSave.Text = Resources.MainForm_MiFileSave;
            SmFileSaveAs.Text = Resources.MainForm_MiFileSaveAs;
            SmFileExport.Text = Resources.MainForm_MiFileExport;
            SmEdit.Text = Resources.MainForm_MiEdit;
            SmEditComment.Text = Resources.MainForm_MiEditComment;
            SmEditCopy.Text = Resources.MainForm_MiEditCopy;
            SmEditCut.Text = Resources.MainForm_MiEditCut;
            SmEditPaste.Text = Resources.MainForm_MiEditPaste;
            SmEditDelete.Text = Resources.MainForm_MiEditDelete;
            SmEditDeleteAll.Text = Resources.MainForm_MiEditDeleteAll;
            SmEditSelectAll.Text = Resources.MainForm_MiEditSelectAll;
            SmEditMoveUp.Text = Resources.MainForm_MiEditMoveUp;
            SmEditMoveDown.Text = Resources.MainForm_MiEditMoveDown;
            SmView.Text = Resources.MainForm_MiView;
            SmViewStatusBar.Text = Resources.MainForm_MiViewStatusBar;
            SmViewReportScheme.Text = Resources.MainForm_MiViewReportScheme;
            SmTools.Text = Resources.MainForm_MiTools;
            SmToolsRegisterFileExt.Text = Resources.MainForm_MiToolsRegisterFileExt;
            SmToolsUnregisterFileExt.Text = Resources.MainForm_MiToolsUnregisterFileExt;
            SmHelp.Text = Resources.MainForm_MiHelp;
            SmHelpHIDSpec.Text = Resources.MainForm_MiHelpHIDSpec;
            SmHelpHIDUsages.Text = Resources.MainForm_MiHelpHIDUsages;
        }

        #endregion

        #region List View Group

        private static readonly ListViewGroup[] GroupCollection =
        {
            new ListViewGroup(Resources.MainForm_GroupMain),
            new ListViewGroup(Resources.MainForm_GroupGlobal),
            new ListViewGroup(Resources.MainForm_GroupLocal),
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
                MessageBox.Show(string.Format(Resources.FileTypeNotSupported, filename), 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show(Resources.NotCollectionStart, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            dlg = new UsagePageForm() { Text = EnumHelper.GetEnumDescription(tagGlobal) };
                            return true;

                        case ItemTagGlobal.LogicalMinimum:
                        case ItemTagGlobal.LogicalMaximum:
                        case ItemTagGlobal.PhysicalMinimum:
                        case ItemTagGlobal.PhysicalMaximum:
                            dlg = new NumberInputForm(-0x80000000, 0x7FFFFFFF) { Text = EnumHelper.GetEnumDescription(tagGlobal) };
                            return true;

                        case ItemTagGlobal.ReportSize:
                        case ItemTagGlobal.ReportCount:
                            dlg = new NumberInputForm(0x00000000, 0xFFFFFFFF) { Text = EnumHelper.GetEnumDescription(tagGlobal) };
                            return true;

                        case ItemTagGlobal.UnitExponent:
                        case ItemTagGlobal.Unit:
                            MessageBox.Show(Resources.NotImplemented, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                        case ItemTagGlobal.ReportID: 
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
                                    dlg = new UsageForm(upType)
                                    {
                                        Text = string.Format(Resources.UsageForm_SelectedUsagePage,
                                            EnumHelper.GetEnumDescription(tagLocal), usagePageName, (int)topUsagePage),
                                    };
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show(string.Format(Resources.MainForm_SetUsagesNotDefined, EnumHelper.GetEnumDescription(topUsagePage.Value)),
                                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show(Resources.MainForm_MustDefinedUsagePage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
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
                    new ListViewSubItem(null, item.ToString(ReportItems, out int openCollectionCount)),
                    new ListViewSubItem(null, item.BytesString) { ForeColor = NumberColor },
                    new ListViewSubItem(null, !string.IsNullOrWhiteSpace(item.Comment)
                        ? $"; {item.Comment}"
                        : string.Empty) { ForeColor = CommentColor },
                }, -1)
                { 
                    Tag = item, 
                    UseItemStyleForSubItems = false, 
                    BackColor = item.Header.Type == ItemType.Main && 
                        ((ItemTagMain)item.Header.Tag == ItemTagMain.EndCollection || (ItemTagMain)item.Header.Tag == ItemTagMain.Collection) &&
                        openCollectionCount < 0 ? Color.IndianRed : Color.Transparent  
                })
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
            SmEditPaste.Enabled = Clipboard.ContainsData(nameof(HIDReportItemCollection));
            SmEditDelete.Enabled = isSelMoreOne;
            SmEditDeleteAll.Enabled = isHasMoreOne;
            SmEditSelectAll.Enabled = isHasMoreOne;
            SmEditMoveUp.Enabled = isHasMoreOne;
            SmEditMoveDown.Enabled = isHasMoreOne;
            // View
            SmViewStatusBar.Checked = isHasMoreOne;
            SmViewReportScheme.Checked = false; // TODO доделать структуру репорта
            // Status Bar
            StatusBarElementCount.Text = string.Format(Resources.MainForm_CountItem, ReportItems.Count);
            StatusBarByteCount.Text = string.Format(Resources.MainForm_CountBytes, ReportItems.Sum(item => item.GetBytes().Length));
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            });
        }

        private void CopyToClipboard(IEnumerable<HIDReportItem> items)
        {
            var collection = new HIDReportItemCollection();
            collection.AddRange(items);

            using var stringWriter = new StringWriter();
            Serializer.Serialize(stringWriter, collection);
            Clipboard.SetData(nameof(HIDReportItemCollection), stringWriter.ToString());
        }

        private void DeleteItems(IEnumerable<HIDReportItem> items)
        {
            foreach (var item in items)
            {
                ReportItems.Remove(item);
            }
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
                    if (LongDialog(longItem))
                    {
                        UpdateListView();
                    }
                }
                else
                    throw new NotSupportedException();
            }
        }

        private bool LongDialog(LongItem longItem)
        {
            var dlg = new HexEditorForm()
            {
                LongTag = longItem.LongItemTag,
                Value = longItem.Value
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                longItem.Value = dlg.Value;
                longItem.LongItemTag = dlg.LongTag;
                IsModified = true;
                return true;
            }

            return false;
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
                var ret = MessageBox.Show(Resources.MainForm_SaveModidiedFile, Application.ProductName,
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

        private void BtnAddLongItem_Click(object sender, EventArgs e)
        {
            var longItem = new LongItem();
            if (LongDialog(longItem))
            {
                ReportItems.Add(longItem);
            }
            UpdateListView();
        }

        private void ContextMenuEdit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EnableUpdate();
        }

        #endregion

        #region Commands

        private void SmFileSaveAs_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = Resources.DialogSaveAs,
                Filter = $"{Resources.FileExtensionCaption} (*{Program.FileExtension})|*{Program.FileExtension}",
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
                    Title = Resources.DialogOpenFile,
                    Filter = $"{Resources.FileExtensionCaption} (*{Program.FileExtension})|*{Program.FileExtension}",
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
            MessageBox.Show(Resources.NotImplemented, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SmEditCopy_Click(object sender, EventArgs e)
        {
            if (ListReportItems.SelectedItems.Count == 0)
            {
                Clipboard.Clear();
                return;
            }

            var selected = ListReportItems.SelectedItems
                .Cast<ListViewItem>()
                .Select(lvi => lvi.Tag as HIDReportItem)
                .ToArray();

            CopyToClipboard(selected);
            EnableUpdate();
        }

        private void SmEditCut_Click(object sender, EventArgs e)
        {
            if (ListReportItems.SelectedItems.Count == 0)
            {
                Clipboard.Clear();
                return;
            }

            var selected = ListReportItems.SelectedItems
                .Cast<ListViewItem>()
                .Select(lvi => lvi.Tag as HIDReportItem);

            CopyToClipboard(selected);

            DeleteItems(selected);

            IsModified = true;
            UpdateListView();
        }

        private void SmEditPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(nameof(HIDReportItemCollection)))
            {
                var data = Clipboard.GetData(nameof(HIDReportItemCollection)) as string;
                using var textReader = new StringReader(data);
                var collection = Serializer.Deserialize(textReader) as HIDReportItemCollection;
                var maxIndexPos = ListReportItems.SelectedItems.Count == 0
                    ? ListReportItems.Items.Count
                    : ListReportItems.SelectedItems.Cast<ListViewItem>().DefaultIfEmpty().Max(lvi => lvi.Index);
                ReportItems.InsertRange(maxIndexPos, collection);
                IsModified = true;
                UpdateListView();
            }
        }

        private void SmEditMoveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.NotImplemented, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); // Move Up
        }

        private void SmEditMoveDown_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.NotImplemented, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); // Move Down
        }

        private void SmEditDelete_Click(object sender, EventArgs e)
        {
            if (ListReportItems.SelectedItems.Count > 0)
            {
                var selected = ListReportItems.SelectedItems
                    .Cast<ListViewItem>()
                    .Select(lvi => lvi.Tag as HIDReportItem);

                DeleteItems(selected);

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
    }
}