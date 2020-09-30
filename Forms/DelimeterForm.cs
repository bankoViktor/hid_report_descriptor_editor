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
                return int.Parse(Controls
                    .OfType<RadioButton>()
                    .Where(rb => rb.Checked)
                    .Single().Tag as string);
            }
            set
            {
                if (value != null)
                {
                    Controls
                        .OfType<RadioButton>()
                        .Where(rb => int.Parse(rb.Tag as string) == (int)value)
                        .Single().Checked = true;
                }
            }
        }

        public DelimeterForm()
        {
            InitializeComponent();
        }
    }
}
