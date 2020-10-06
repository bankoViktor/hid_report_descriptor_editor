using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class UsagePageForm : Form, IDialogValue
    {
        public object Value
        {
            get => ListUsagePages.SelectedItems.Count == 1
                ? ListUsagePages.SelectedItems[0].Tag : null;
            set
            {
                if (value != null)
                {
                    SelectItem(value);
                }
            }
        }

        public UsagePageForm()
        {
            InitializeComponent();

            var type = typeof(UsagePage);

            ListUsagePages.DoubleBuffering(true);
            ListUsagePages.Items.Clear();
            ListUsagePages.Items.AddRange(type.GetFields()
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
                    }, -1)
                    { Tag = _enum_, UseItemStyleForSubItems = false };
                })
                .ToArray());

            SelectUsagePageForm_Resize(null, EventArgs.Empty);

            ListUsagePages.Select();
        }

        private void SelectItem(object value)
        {
            var item = ListUsagePages.Items
                        .Cast<ListViewItem>()
                        .Where(lvi => lvi.Tag.Equals(value))
                        .SingleOrDefault();

            if (item != null)
            {
                item.Selected = true;
                item.Focused = true;
                ListUsagePages.TopItem = item;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ListUsagePages.SelectedItems.Count == 1)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            BtnOK_Click(null, EventArgs.Empty);
        }

        private void SelectUsagePageForm_Resize(object sender, EventArgs e)
        {
            float[] widths =
            {
                0.85f,
                0.15f,
            };

            for (int i = 0; i < ListUsagePages.Columns.Count; i++)
            {
                var column = ListUsagePages.Columns[i];
                var width = ListUsagePages.Width - SystemInformation.VerticalScrollBarWidth - 8;
                column.Width = (int)(widths[i] * width);
            }
        }
    }
}