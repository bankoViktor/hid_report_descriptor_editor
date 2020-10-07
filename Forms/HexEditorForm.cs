using HID_Report_Descriptor_Editor.Properties;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class HexEditorForm : Form, IDialogValue
    {
        public object Value
        {
            get => TryBytesDumnParse(TbDump.Text.Replace(" ", ""), out byte[] buffer) ? buffer : null;
            set
            {
                if (value != null && value is byte[] buffer)
                {
                    TbDump.Text = BitConverter.ToString(buffer, 0).Replace("-", " ");
                }
            }
        }

        public byte LongTag
        {
            get => byte.Parse(TbLongTag.Text, NumberStyles.HexNumber);
            set => TbLongTag.Text = value.ToString("X");
        }

        public HexEditorForm()
        {
            InitializeComponent();
            // Localize
            BtnOK.Text = Resources.AcceptButton;
            BtnCancel.Text = Resources.CancelButton;
            LabelLongTag.Text = Resources.HexEditorForm_LongTag;
            LabelDump.Text = Resources.HexEditorForm_Dump;
        }

        private void TbLongTag_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(TbLongTag.Text, NumberStyles.HexNumber, null, out int value))
            {
                if (value >= 0 && value <= 255)
                {
                    errorProvider1.SetError(TbLongTag, string.Empty);
                }
                else
                {
                    errorProvider1.SetError(TbLongTag, Resources.HexEditorForm_LongTagOutOfRange);
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(TbLongTag, Resources.HexEditorForm_LongDataSizeOutOfRange);
                e.Cancel = true;
            }
        }

        private void TbDump_Validating(object sender, CancelEventArgs e)
        {
            if (TryBytesDumnParse(TbDump.Text.Replace(" ", ""), out byte[] buffer))
            {
                if (buffer.Length <= 255)
                {
                    errorProvider1.SetError(TbDump, string.Empty);
                }
                else
                {
                    errorProvider1.SetError(TbDump, Resources.HexEditorForm_LongDataSizeOutOfRange);
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(TbDump, Resources.HexEditorForm_InvalidValue);
                e.Cancel = true;
            }
        }

        public bool TryBytesDumnParse(string hex, out byte[] buffer)
        {
            if (hex.Length % 2 == 1)
            {
                buffer = null;
                return false;
            }

            buffer = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                buffer[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return true;
        }

        public static int GetHexVal(char hex)
        {
            int val = hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
    }
}