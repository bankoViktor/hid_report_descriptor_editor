using System.Diagnostics;
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
        }
        //const string RepositoryURL = "";

        private void BtnVisitWebSite_Click(object sender, System.EventArgs e)
        {
            var url = "";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            });
        }

        private void LinkEmail_Click(object sender, System.EventArgs e)
        {
            var addr = LinkEmail.Text;
            var subj = $"{Application.ProductName}, version {Application.ProductVersion}";
            var url = $"mailto:{addr}?subject=\"{subj}\"";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            });
        }
    }
}
