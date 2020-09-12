using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            LabelProductName.Text = Application.ProductName;
            LabelProductVersion.Text = "v" + Application.ProductVersion;
            LabelAuthor.Text = Application.CompanyName;
        }
    }
}
