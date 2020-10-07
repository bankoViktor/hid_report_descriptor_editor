using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Properties;
using HID_Report_Descriptor_Editor.Utils;
using System;
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
                return (CollectionType)GbCollections.Controls
                    .OfType<RadioButton>()
                    .First(rb => rb.Checked).Tag;
            }
            set
            {
                if (value != null)
                {
                    GbCollections.Controls
                       .OfType<RadioButton>()
                       .Where(rb =>
                       {
                           var left = (CollectionType)Convert.ChangeType(rb.Tag, typeof(CollectionType));
                           var right = (CollectionType)Convert.ToInt32(value);
                           return left == right;
                       })
                       .Single().Checked = true;
                }
            }
        }

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

            // Localize
            GbCollections.Text = Resources.CollectionForm_GroupBoxCollectionType;
            BtnOK.Text = Resources.AcceptButton;
            BtnCancel.Text = Resources.CancelButton;
        }
    }
}
