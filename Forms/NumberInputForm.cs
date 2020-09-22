using HID_Report_Descriptor_Editor.Utils;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class NumberInputForm : Form, IDialogValue
    {
        private uint MinValue { get; }
        private uint MaxValue { get; }
        public object Value
        {
            get
            {
                throw new NotImplementedException();
                //var converter = new Int64Converter();
                //if (converter.CanConvertFrom(typeof(string)))
                //{

                //}
                //else
                //    return null; Int64Converter.Parse(TbValue.Text);
            }
            set => TbValue.Text = value != null ? value.ToString() : "0"; 
        }
        public string Caption { get; set; }

        public NumberInputForm(uint min, uint max)
        {
            InitializeComponent();
            MinValue = min;
            MaxValue = max;

            TbValue.Text = "0";
            TbValue.Select();
        }

        private void CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void TbValue_TextChanged(object sender, System.EventArgs e)
        {
            //BtnOK.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) && int.TryParse(textBox1.Text, out int result);
        }
    }
}
