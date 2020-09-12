using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class SelectorForm : Form, IDialogValue
    {
        private Type TypeValue { get; }
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
        public string Caption { get => label1.Text; set => label1.Text = value; }

        public SelectorForm(Type type)
        {
            InitializeComponent();

            listView1.DoubleBuffering(true);

            TypeValue = type;

            listView1.Items.Clear();
            listView1.Items.AddRange(TypeValue.GetFields()
                .Where(f => f.FieldType == TypeValue)
                .OrderBy(f => (int)Enum.Parse(TypeValue, f.Name))
                .Select(f =>
                {
                    var value = Enum.Parse(TypeValue, f.Name);
                    var name = ShortItem.GetEnumDescription(value);
                    return new ListViewItem(new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(null, name),
                        new ListViewItem.ListViewSubItem(null, string.Format("{0,4:X4}", (int)value) ) { ForeColor = Color.Gray },
                    }, -1)
                    { Tag = value, UseItemStyleForSubItems = false };
                })
                .ToArray());

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
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            BtnOK_Click(null, EventArgs.Empty);
        }
    }
}
