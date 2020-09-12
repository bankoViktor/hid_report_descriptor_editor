using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Utils;
using System.Linq;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Forms
{
    public partial class CollectionForm : Form, IDialogValue
    {
        public object Value
        {
            get
            {
                return groupBox1.Controls
                    .OfType<RadioButton>()
                    .First(rb => rb.Checked).Tag;
            }
            set
            {
                if (value != null)
                {
                    groupBox1.Controls
                       .OfType<RadioButton>()
                       .Where(rb => (CollectionType)rb.Tag == (CollectionType)value)
                       .Single().Checked = true;
                }
            }
        }
        public string Caption { get; set; }

        public CollectionForm()
        {
            InitializeComponent();
            ColTypePhysical.Tag = CollectionType.Physical;
            ColTypeApplication.Tag = CollectionType.Application;
            ColTypeLogical.Tag = CollectionType.Logical;
            ColTypeReport.Tag = CollectionType.Report;
            ColTypeNamedArray.Tag = CollectionType.NamedArray;
            ColTypeUsageSwitch.Tag = CollectionType.UsageSwitch;
            ColTypeUsageModifier.Tag = CollectionType.UsageModifier;
            ColTypeVendorDefined.Tag = CollectionType.VendorDefined;
        }
    }
}
