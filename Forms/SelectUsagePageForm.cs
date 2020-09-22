using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class SelectUsagePageForm : Form, IDialogValue
    {
        public object Value
        {
            get
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    return (int)listView1.SelectedItems[0].Tag;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != null)
                {
                    var item = listView1.Items
                        .Cast<ListViewItem>()
                        .Where(lvi => (int)lvi.Tag == (int)value)
                        .SingleOrDefault();
                    if (item != null)
                    {
                        item.Selected = true;
                        item.Focused = true;
                    }
                }
                listView1.Select();
            }
        }

        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SelectUsagePageForm()
        {
            InitializeComponent();

            var type = typeof(UsagePage);

            listView1.DoubleBuffering(true);
            listView1.Items.Clear();
            listView1.Items.AddRange(type.GetFields()
                .Where(f => f.FieldType == type)
                .OrderBy(f => (int)Enum.Parse(type, f.Name))
                .Select(f =>
                {
                    var value = Enum.Parse(type, f.Name);
                    var name = ShortItem.GetEnumDescription(value);
                    return new ListViewItem(new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(null, name),
                        new ListViewItem.ListViewSubItem(null, string.Format("{0:X4}", (int)value) ) { ForeColor = Color.Gray },
                        new ListViewItem.ListViewSubItem(null, "s" ) { ForeColor = Color.Gray },
                    }, -1)
                    { Tag = value, UseItemStyleForSubItems = false };
                })
                .ToArray());

            SelectUsagePageForm_Resize(null, EventArgs.Empty);

            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Items[0].Focused = true;
            }
            listView1.Select();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Value = (int)listView1.SelectedItems[0].Tag;
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

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                var column = listView1.Columns[i];
                var width = listView1.Width - SystemInformation.VerticalScrollBarWidth - 8;
                column.Width = (int)(widths[i] * width);
            }
        }
    }
}
