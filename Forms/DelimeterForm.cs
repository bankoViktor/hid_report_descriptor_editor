using HID_Report_Descriptor_Editor.Utils;
using System.Linq;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class DelimeterForm : Form, IDialogValue
    {
        public object Value
        {
            get
            {
                return (int)Controls
                    .Cast<RadioButton>()
                    .Where(rb => rb.Checked)
                    .Single().Tag;
            }
            set
            {
                Controls
                    .Cast<RadioButton>()
                    .Where(rb => (int)rb.Tag == (int)value)
                    .Single().Checked = true;
            }
        }
        public string Caption { get; set; }

        public DelimeterForm()
        {
            InitializeComponent();
        }
    }
}
