using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums
{
    public enum CollectionType : byte
    {
        [Description("Physical")]
        Physical = 0x00,

        [Description("Application")]
        Application = 0x01,

        [Description("Logical")]
        Logical = 0x02,

        [Description("Report")]
        Report = 0x03,

        [Description("Named Array")]
        NamedArray = 0x04,

        [Description("Usage Switch")]
        UsageSwitch = 0x05, 

        [Description("Usage Modifier")]
        UsageModifier = 0x06,

        // reserved 0x07 - 0x7F

        [Description("Vendor Defined")]
        VendorDefined = 0x80,

        // vendor-defined 0x80 - 0xFF
    }
}
