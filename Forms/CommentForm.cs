using HID_Report_Descriptor_Editor.Properties;
using System;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class CommentForm : Form
    {
        public string Comment { get => TbComment.Text; set => TbComment.Text = value; }

        public CommentForm()
        {
            InitializeComponent();
            BtnClear_Click(null, EventArgs.Empty);
            // Localize
            Text = Resources.CommentForm_Title;
            BtnOK.Text = Resources.AcceptButton;
            BtnCancel.Text = Resources.CancelButton;
            BtnClear.Text = Resources.ClearButton;
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            TbComment.Text = string.Empty;
            TbComment.Select();
        }
    }
}