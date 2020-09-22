using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Utils;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class InputForm : Form, IDialogValue
    {
        public object Value
        {
            get
            {
                var b0 = rb0_Constant.Checked ? 1 : 0;
                var b1 = rb1_Variable.Checked ? 1 : 0;
                var b2 = rb2_Relative.Checked ? 1 : 0;
                var b3 = rb3_Wrap.Checked ? 1 : 0;
                var b4 = rb4_NoLinear.Checked ? 1 : 0;
                var b5 = rb5_NoPreferred.Checked ? 1 : 0;
                var b6 = rb6_NullState.Checked ? 1 : 0;
                var b7 = rb7_Valatile.Checked ? 1 : 0;
                var b8 = rb8_Buffered.Checked ? 1 : 0;
                return
                    (b8 << 8) |
                    (b7 << 7) | (b6 << 6) | (b5 << 5) | (b4 << 4) |
                    (b3 << 3) | (b2 << 2) | (b1 << 1) | (b0 << 0);
            }
            set
            {
                if (value != null && value is int val)
                {
                    var b0 = val & (1 << 0);
                    rb0_Data.Checked = !(b0 > 0);
                    rb0_Constant.Checked = (b0 > 0);

                    var b1 = val & (1 << 1);
                    rb1_Array.Checked = !(b1 > 0);
                    rb1_Variable.Checked = (b1 > 0);

                    var b2 = val & (1 << 2);
                    rb2_Absolute.Checked = !(b2 > 0);
                    rb2_Relative.Checked = (b2 > 0);

                    var b3 = val & (1 << 3);
                    rb3_NoWrap.Checked = !(b3 > 0);
                    rb3_Wrap.Checked = (b3 > 0);

                    var b4 = val & (1 << 4);
                    rb4_Linear.Checked = !(b4 > 0);
                    rb4_NoLinear.Checked = (b4 > 0);

                    var b5 = val & (1 << 5);
                    rb5_PreferredState.Checked = !(b5 > 0);
                    rb5_NoPreferred.Checked = (b5 > 0);

                    var b6 = val & (1 << 6);
                    rb6_NotNullPosition.Checked = !(b6 > 0);
                    rb6_NullState.Checked = (b6 > 0);

                    var b7 = val & (1 << 7);
                    rb7_NotValatile.Checked = !(b7 > 0);
                    rb7_Valatile.Checked = (b7 > 0);

                    var b8 = val & (1 << 8);
                    rb8_BitField.Checked = !(b8 > 0);
                    rb8_Buffered.Checked = (b8 > 0);
                }
            }
        }
        public string Caption { get; set; }

        public InputForm(ItemTagMain itemTagMain)
        {
            InitializeComponent();

            switch (itemTagMain)
            {
                case ItemTagMain.Input:
                    gb7.Enabled = false;
                    break;
            }
        }
    }
}
