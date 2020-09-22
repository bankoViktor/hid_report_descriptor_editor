using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class SelectUsageForm : Form, IDialogValue
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

        public SelectUsageForm(Type type)
        {
            InitializeComponent();

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
                        new ListViewItem.ListViewSubItem(null, f.GetCustomAttribute<UsageTypeAttribute>()?.UsageValueType ) { ForeColor = Color.Gray },
                    }, -1)
                    { Tag = value, UseItemStyleForSubItems = false };
                })
                .ToArray());

            SelectUsageForm_Resize(null, EventArgs.Empty);

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
                Value = listView1.SelectedItems[0].Tag;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            BtnOK_Click(null, EventArgs.Empty);
        }

        private void SelectUsageForm_Resize(object sender, EventArgs e)
        {
            float[] widths =
            {
                0.55f,
                0.15f,
                0.30f,
            };

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                var column = listView1.Columns[i];
                var width = listView1.Width - SystemInformation.VerticalScrollBarWidth - 5;
                column.Width = (int)(widths[i] * width);
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help");
            // TODO подсказка Usage-типы
        }
    }
}
