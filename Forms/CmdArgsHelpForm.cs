using HID_Report_Descriptor_Editor.Properties;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class CmdArgsHelpForm : Form
    {
        public string Caption
        {
            get => LabelCaption.Text;
            set => LabelCaption.Text = value;
        }

        public CmdArgsHelpForm()
        {
            InitializeComponent();
            Text = Application.ProductName;
            BtnOk.Text = Resources.AcceptButton;
        }
    }
}