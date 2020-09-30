using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class NumberInputForm : Form, IDialogValue
    {
        //private uint MinValue { get; }
        //private uint MaxValue { get; }

        public object Value
        {
            get => GetValue();
            set => TbValue.Text = value == null ? "0" : value.ToString();
        }

        public NumberInputForm(uint min, uint max)
        {
            InitializeComponent();
            TbValue.Text = "0";
            TbValue.Select();
        }

        private int? GetValue()
        {
            if (RbDEC.Checked)
            {
                return int.Parse(TbValue.Text);
            }
            else if (RbHEX.Checked)
            {
                return int.Parse(TbValue.Text, System.Globalization.NumberStyles.HexNumber);
            }

            return null;
        }


        private void RbDEC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RbDEC.Checked)
                TbValue.Text = int.Parse(TbValue.Text, System.Globalization.NumberStyles.HexNumber).ToString("D");
        }

        private void RbHEX_CheckedChanged(object sender, EventArgs e)
        {
            if (RbHEX.Checked)
                TbValue.Text = int.Parse(TbValue.Text).ToString("X");
        }
    }
}