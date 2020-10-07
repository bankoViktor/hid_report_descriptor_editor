using HID_Report_Descriptor_Editor.Properties;
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

            // Localize
            Text = Resources.AboutForm_Title;
            BtnVisitWebSite.Text = Resources.AboutForm_VisitWebButton;
            BtnOK.Text = Resources.AcceptButton;
        }

        private void BtnVisitWebSite_Click(object sender, System.EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {Program.UrlRepository}")
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
