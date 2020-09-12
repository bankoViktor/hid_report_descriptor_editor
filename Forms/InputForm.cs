using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class InputForm : Form, IDialogValue
    {
        public object Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Caption { get; set; }

        public InputForm()
        {
            InitializeComponent();
        }
    }
}
