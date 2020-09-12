using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums
{
    public enum ItemTagMain
    {
        // ширина 4 бита
        // reserved 0b0000 - 0b0111
        [Description("INPUT")]
        Input = 0b1000,
        [Description("OUTPUT")]
        Output = 0b1001,
        [Description("COLLECTION")]
        Collection = 0b1010,
        [Description("FEATURE")]
        Feature = 0b1011,
        [Description("END COLLECTION")]
        EndCollection = 0b1100,
        // reserved 0b1101 - 0b1111
    }

    public enum ItemTagGlobal
    {
        // ширина 4 бита
        [Description("USAGE PAGE")]
        UsagePage = 0b0000,
        [Description("LOGICAL MINIMUM")]
        LogicalMinimum = 0b0001,
        [Description("LOGICAL MAXIMUM")]
        LogicalMaximum = 0b0010,
        [Description("PHYSICAL MINIMUM")]
        PhysicalMinimum = 0b0011,
        [Description("PHYSICAL MAXIMUM")]
        PhysicalMaximum = 0b0100,
        [Description("UNIT EXPONENT")]
        UnitExponent = 0b0101,
        [Description("UNIT")]
        Unit = 0b0110,
        [Description("REPORT SIZE")]
        ReportSize = 0b0111,
        [Description("REPORT ID")]
        ReportID = 0b1000,
        [Description("REPORT COUNT")]
        ReportCount = 0b1001,
        [Description("PUSH")]
        Push = 0b1010,
        [Description("POP")]
        Pop = 0b1011,
        // reserved 0b1100 - 0b1111
    }

    public enum ItemTagLocal
    {
        // ширина 4 бита
        [Description("USAGE")]
        Usage = 0b0000,
        [Description("USAGE MINIMUM")]
        UsageMinimum = 0b0001,
        [Description("USAGE MAXIMUM")]
        UsageMaximum = 0b0010,
        [Description("DESIGNATOR INDEX")]
        DesignatorIndex = 0b0011,
        [Description("DESIGNATOR MINIMUM")]
        DesignatorMinimum = 0b0100,
        [Description("DESIGNATOR MAXIMUM")]
        DesignatorMaximum = 0b0101,
        // reserved 0b0110
        [Description("STRING INDEX")]
        StringIndex = 0b0111,
        [Description("STRING MINIMUM")]
        StringMinimum = 0b1000,
        [Description("STRING MAXIMUM")]
        StringMaximum = 0b1001,
        [Description("DELIMITER")]
        Delimiter = 0b1010,
        // reserved 0b1011 - 0b1111
    }
}