using HID_Report_Descriptor_Editor.Properties;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class NumberInputForm : Form, IDialogValue
    {
        public long MinValue { get; set; }
        public long MaxValue { get; set; }

        public object Value
        {
            get => GetValue();
            set => TbValue.Text = value == null ? "0" : value.ToString();
        }

        public NumberInputForm(long min, long max)
        {
            InitializeComponent();
            MinValue = min;
            MaxValue = max;
            TbValue.Select();
            TbValue.Text = "0";
            // Localize
            BtnOK.Text = Resources.AcceptButton;
            BtnCancel.Text = Resources.CancelButton;
            LabelRange.Text = string.Format(Resources.NumberInput_Range, MinValue, MaxValue);
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

        private void RbDEC_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDEC.Checked)
            {
                TbValue.Text = int.Parse(TbValue.Text, System.Globalization.NumberStyles.HexNumber).ToString("D");
            }

            errorProvider1.SetError(TbValue, string.Empty);
            TbValue.Select();
        }

        private void RbHEX_CheckedChanged(object sender, EventArgs e)
        {
            if (RbHEX.Checked)
            {
                TbValue.Text = int.Parse(TbValue.Text).ToString("X");
            }

            errorProvider1.SetError(TbValue, string.Empty);
            TbValue.Select();
        }

        private void TbValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(TbValue, string.Empty);

            try
            {
                var value = GetValue();

                if (!value.HasValue)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TbValue, Resources.NumberInput_InvalidValue);
                    return;
                }

                if (value < MinValue)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TbValue, string.Format(Resources.NumberInput_InvalidValueLess, MinValue));
                    return;
                }

                if (value > MaxValue)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TbValue, string.Format(Resources.NumberInput_InvalidValueGreater, MaxValue));
                    return;
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(TbValue, Resources.NumberInput_InvalidValue);
                e.Cancel = true;
            }
        }
    }
}