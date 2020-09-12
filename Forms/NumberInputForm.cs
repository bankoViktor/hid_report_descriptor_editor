using HID_Report_Descriptor_Editor.Utils;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class NumberInputForm : Form, IDialogValue
    {
        private uint MinValue { get; }
        private uint MaxValue { get; }
        public object Value { get => int.Parse(textBox1.Text); set => textBox1.Text = value != null ? value.ToString() : "0"; }
        public string Caption { get; set; }

        public NumberInputForm(uint min, uint max)
        {
            InitializeComponent();
            MinValue = min;
            MaxValue = max;

            textBox1.Text = "0";
            textBox1.Select();
        }

        private void CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            //BtnOK.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) && int.TryParse(textBox1.Text, out int result);
        }
    }
}
