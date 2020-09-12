using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class MainForm : Form
    {
        private bool _isModified;

        private List<ShortItem> ReportItems { get; set; }
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
                Text = $"{Application.ProductName} - [{(IsModified ? "*" : "")}{Path.GetFileName(Filename)}]";
            }
        }
        public int LastSelIndex { get; set; } = -1;


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
            ListItemPalet.DoubleBuffering(true);
            ListItems.DoubleBuffering(true);

            ListItemPalet.Groups.AddRange(GroupCollection);
            ListItemPalet.Items.AddRange(ShortItem.ShortItemsCollection
                .Select(i => new ListViewItem(i.Name, GetLVGroup(i.Type)) { Tag = i })
                .ToArray());
        }

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

        private void CreateFile(string filename)
        {
            Filename = filename;
            ReportItems = new List<ShortItem>();
            IsModified = false;
            IsNewFile = true;
        }

        private void OpenFile(string filename)
        {
            Filename = filename;
            IsModified = false;
            ReportItems = LoadFile(filename);
            UpdateListView();
        }

        public static List<ShortItem> LoadFile(string filename)
        {
            var result = new List<ShortItem>();
            var reader = new BinaryReader(File.OpenRead(filename));

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                var _byte = reader.ReadByte();

                var size = (ItemSize)(_byte & 0x03);
                var type = (ItemType)((_byte & 0x0C) >> 2);
                var tag = (_byte & 0xF0) >> 4;

                object value = size switch
                {
                    ItemSize.Byte => (int)reader.ReadByte(),
                    ItemSize.Word => (int)reader.ReadInt16(),
                    ItemSize.DWord => reader.ReadInt32(),
                    ItemSize.Null => null,
                    _ => null,
                };

                result.Add(new ShortItem(type, tag, value));
            }

            reader.Close();

            return result;
        }

        private void Save(string filename)
        {
            var writer = new BinaryWriter(File.Open(filename, FileMode.Create));

            foreach (var item in ReportItems)
            {
                var bytes = item.GetBytes();
                writer.Write(bytes, 0, bytes.Length);
            }

            writer.Close();
        }

        private void AddReportItem(ShortItem item)
        {
            if (DoDialog(item, out IDialogValue dlg))
            {
                if (dlg == null)
                {
                    item.Value = null;
                    IsModified = true;
                    ReportItems.Add(item);
                }
                else
                {
                    dlg.Value = item.Value;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        item.Value = (int)dlg.Value;
                        IsModified = true;
                        ReportItems.Add(item);
                    }
                }
            }

            UpdateListView();
        }

        private bool DoDialog(ShortItem item, out IDialogValue dlg)
        {
            dlg = null;

            if (item.Tag is ItemTagMain tagMain)
            {
                switch (tagMain)
                {
                    case ItemTagMain.Collection:
                        dlg = new CollectionForm();
                        return true;

                    case ItemTagMain.Input:
                    case ItemTagMain.Output:
                    case ItemTagMain.Feature:
                        dlg = new InputForm();
                        return true;

                    case ItemTagMain.EndCollection:
                        var currentCollection = GetCurrentCollection();
                        if (currentCollection == null)
                            MessageBox.Show("Not matching Collection statrt.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                }
            }
            else if (item.Tag is ItemTagGlobal tagGlobal)
            {
                switch (tagGlobal)
                {
                    case ItemTagGlobal.UsagePage:
                        dlg = new SelectorForm(typeof(UsagePage)) { Caption = "Select Usage Page" };
                        return true;

                    case ItemTagGlobal.LogicalMinimum:
                    case ItemTagGlobal.LogicalMaximum:
                    case ItemTagGlobal.PhysicalMinimum:
                    case ItemTagGlobal.PhysicalMaximum:
                    case ItemTagGlobal.ReportSize:
                    case ItemTagGlobal.ReportCount:
                        dlg = new NumberInputForm(0x00000000, 0xFFFFFFFF);
                        return true;

                    case ItemTagGlobal.UnitExponent:
                    case ItemTagGlobal.Unit:
                        MessageBox.Show("Not Implemented.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;

                    case ItemTagGlobal.ReportID: // 1 byte
                        dlg = new NumberInputForm(0x00, 0xFF);
                        return true;

                    case ItemTagGlobal.Push:
                    case ItemTagGlobal.Pop:
                        return true;
                }
            }
            else if (item.Tag is ItemTagLocal tagLocal)
            {
                switch (tagLocal)
                {
                    case ItemTagLocal.Usage:
                    case ItemTagLocal.UsageMinimum:
                    case ItemTagLocal.UsageMaximum:
                        var topUsagePage = ShortItem.GetTopUsagePage(ReportItems, GetBaseIndex());
                        if (topUsagePage.HasValue && topUsagePage.Value != UsagePage.Undefined)
                        {
                            var upType = ShortItem.GetUsagePageType(topUsagePage.Value);
                            if (upType != null)
                            {
                                var usagePageName = ShortItem.GetEnumDescription(topUsagePage);
                                dlg = new SelectorForm(upType) { Caption = $"USAGE PAGE: {usagePageName} (0x{(int)topUsagePage,4:X4})" };
                                return true;
                            }
                        }
                        else
                            MessageBox.Show("You mast define a Usage Page before selecting a Usage.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case ItemTagLocal.DesignatorIndex:
                    case ItemTagLocal.DesignatorMinimum:
                    case ItemTagLocal.DesignatorMaximum:
                    case ItemTagLocal.StringIndex:
                    case ItemTagLocal.StringMinimum:
                    case ItemTagLocal.StringMaximum:
                        dlg = new NumberInputForm(0x00000000, 0xFFFFFFFF);
                        return true;

                    case ItemTagLocal.Delimiter:
                        dlg = new DelimeterForm();
                        return true;
                }
            }

            return false;
        }

        private int GetBaseIndex()
        {
            return ListItems.SelectedItems.Count > 0
                  ? ListItems.SelectedItems.Cast<ListViewItem>().Max(i => i.Index)
                  : ReportItems.Count;
        }

        private object GetCurrentCollection()
        {
            var index = ListItems.SelectedItems.Count > 0
             ? ListItems.SelectedItems.Cast<ListViewItem>().Max(i => i.Index)
             : ListItems.Items.Count;

            foreach (var item in ReportItems.Reverse<ShortItem>().Skip(ReportItems.Count - index))
            {
                if (item.Type == ItemType.Main && item.Tag is ItemTagMain main && main == ItemTagMain.Collection)
                {
                    return (CollectionType)item.Value;
                }
            }

            return null;
        }

        private void UpdateListView()
        {
            ListItems.Items.Clear();
            ListItems.Items.AddRange(ReportItems
                .Select((i, index) => new ListViewItem(new string[]
                {
                    ShortItem.GetDisplayText(ReportItems, index),// GetBaseIndex()),
                    i.BytesString,
                }, -1)
                { Tag = i })
                .ToArray());

            EnableUpdate();
        }

        private void EnableUpdate()
        {
            var isSelMoreOne = ListItems.SelectedItems.Count > 0;
            var isHasMoreOne = ListItems.Items.Count > 0;
            // File
            SmFileSave.Enabled = isHasMoreOne && IsModified;
            SmFileSaveAs.Enabled = isHasMoreOne;
            SmFileExport.Enabled = isHasMoreOne;
            // Edit
            SmEditCut.Enabled = isSelMoreOne;
            SmEditCopy.Enabled = isSelMoreOne;
            SmEditPaste.Enabled = true; // TODO имеется вырезанные/скопированные элементы
            SmEditDelete.Enabled = isSelMoreOne;
            SmEditDeleteAll.Enabled = isHasMoreOne;
            SmEditSelectAll.Enabled = isHasMoreOne;
            // View
            SmViewStatusBar.Checked = isHasMoreOne;
            SmViewReportScheme.Checked = false; // TODO доделать структуру репорта
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            });
        }

        #region Events

        private void ListItems_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListView listView && listView.SelectedItems.Count == 1)
            {
                if (listView.SelectedItems[0].Tag is ShortItem item)
                {
                    if (DoDialog(item, out IDialogValue dlg) && dlg != null)
                    {
                        dlg.Value = (int)item.Value;
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            item.Value = (int)dlg.Value;
                            IsModified = true;
                            UpdateListView();
                        }
                    }
                }
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
                        Command_FileSave(null, EventArgs.Empty);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void ListItemPalet_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListView listView && listView.SelectedItems.Count == 1)
            {
                if (listView.SelectedItems[0].Tag is ShortItem item)
                {
                    AddReportItem(new ShortItem(item));
                }
            }
        }

        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableUpdate();
        }

        #endregion

        #region Commands

        private void Command_FileSaveAs(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = "Save As ...",
                Filter = $"Memory Dump (*{Program.FileExtension})|*{Program.FileExtension}",
                InitialDirectory = Path.GetDirectoryName(Filename),
                FileName = Path.GetFileName(Filename),
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Save(dlg.FileName);
                Filename = dlg.FileName;
                IsModified = false;
            }
        }

        private void Command_FileOpen(object sender, EventArgs e)
        {
            var args = new FormClosingEventArgs(CloseReason.UserClosing, false);
            MainForm_FormClosing(null, args);
            if (!args.Cancel)
            {
                var dlg = new OpenFileDialog()
                {
                    Title = "Open File",
                    Filter = $"Memory Dump (*{Program.FileExtension})|*{Program.FileExtension}",
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    OpenFile(dlg.FileName);
                    IsNewFile = false;
                }
            }
        }

        private void Command_FileExport(object sender, EventArgs e)
        {
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
        }

        private void Command_FileSave(object sender, EventArgs e)
        {
            if (IsNewFile)
            {
                Command_FileSaveAs(null, EventArgs.Empty);
                IsNewFile = false;
            }
            else
            {
                Save(Filename);
                IsModified = false;
            }
        }

        private void Command_EditDelete(object sender, EventArgs e)
        {
            if (ListItems.SelectedItems.Count > 0)
            {
                ListItems.SelectedItems
                    .Cast<ListViewItem>()
                    .ToList()
                    .ForEach(f => ReportItems.Remove(f.Tag as ShortItem));

                IsModified = true;
                UpdateListView();
            }
        }

        private void Command_EditDeleteAll(object sender, EventArgs e)
        {
            ReportItems.Clear();
            IsModified = true;
            UpdateListView();
        }

        private void Command_EditSelectAll(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListItems.Items)
            {
                item.Selected = true;
                item.Focused = true;
            }
        }

        private void Command_HelpAbout(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void Command_HelpHIDSpec(object sender, EventArgs e)
        {
            const string url = "https://www.usb.org/sites/default/files/hid1_11.pdf";
            OpenUrl(url);
        }

        private void Command_HelpHIDUsages(object sender, EventArgs e)
        {
            const string url = "https://www.usb.org/sites/default/files/documents/hut1_12v2.pdf";
            OpenUrl(url);
        }

        #endregion
    }
}
