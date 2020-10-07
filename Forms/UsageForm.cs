﻿using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Properties;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class UsageForm : Form, IDialogValue
    {
        public object Value
        {
            get => ListUsages.SelectedItems.Count > 0
                ? ListUsages.SelectedItems[0].Tag : null;
            set
            {
                if (value != null)
                {
                    SeletItem(value);
                }
            }
        }

        public UsageForm(Type type)
        {
            InitializeComponent();

            ListUsages.DoubleBuffering(true);
            ListUsages.Items.Clear();
            ListUsages.Items.AddRange(type.GetFields()
                .Where(f => f.FieldType == type)
                .OrderBy(f => Enum.Parse(type, f.Name))
                .Select(f =>
                {
                    var _enum_ = Enum.Parse(type, f.Name);
                    var name = EnumHelper.GetEnumDescription(_enum_);
                    var enum_numb = Convert.ChangeType(_enum_, typeof(int));
                    return new ListViewItem(new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(null, name),
                        new ListViewItem.ListViewSubItem(null, $"{enum_numb:X4}") { ForeColor = Color.Gray },
                        new ListViewItem.ListViewSubItem(null, f.GetCustomAttribute<UsageTypeAttribute>()?.UsageValueType ) { ForeColor = Color.Gray },
                    }, -1)
                    { Tag = _enum_, UseItemStyleForSubItems = false };
                })
                .ToArray());

            ColumnName.DisplayIndex = 0;
            ColumnName.DisplayIndex = 1;
            ColumnType.DisplayIndex = 2;

            SelectUsageForm_Resize(null, EventArgs.Empty);
            ListUsages.Select();

            // Localize
            BtnOK.Text = Resources.AcceptButton;
            BtnCancel.Text = Resources.CancelButton;
            BtnHelp.Text = Resources.HelpButton;
            ColumnName.Text = Resources.UsageForm_ColumnName;
            ColumnHEX.Text = Resources.UsageForm_ColumnHex;
            ColumnType.Text = Resources.UsageForm_ColumnType;
        }

        private void SeletItem(object value)
        {
            var item = ListUsages.Items
                        .Cast<ListViewItem>()
                        .Where(lvi => lvi.Tag.Equals(value))
                        .SingleOrDefault();

            if (item != null)
            {
                item.Selected = true;
                item.Focused = true;
                ListUsages.TopItem = item;
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SelectUsageForm_Resize(object sender, EventArgs e)
        {
            float[] widths =
            {
                0.55f,
                0.15f,
                0.30f,
            };

            for (int i = 0; i < ListUsages.Columns.Count; i++)
            {
                var column = ListUsages.Columns[i];
                var width = ListUsages.Width - SystemInformation.VerticalScrollBarWidth - 5;
                column.Width = (int)(widths[i] * width);
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help");
        }
    }
}