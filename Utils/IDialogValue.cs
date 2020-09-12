using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Utils
{
    public interface IDialogValue
    {
        object Value { get; set; }
        string Caption { get; set; }

        DialogResult ShowDialog();
    }
}