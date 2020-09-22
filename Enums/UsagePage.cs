using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Enums.UsagePages;
using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums
{
    public enum UsagePage
    {
        // ширина 2 байта
        [Description("Undefined")]
        Undefined = 0x0000,

        [Description("Generic Desktop Controls")]
        [UsagePage(typeof(UsageGenericDesktop))]
        GenericDesktopControls = 0x0001,

        [Description("Simulation Controls")]
        [UsagePage(typeof(UsageSimulationControls))]
        SimulationControls = 0x0002,

        [Description("VR Controls")]
        VRControls = 0x0003,

        [Description("Sport Controls")]
        SportControls = 0x0004,

        [Description("Game Controls")]
        GameControls = 0x0005,

        [Description("Generic Device Controls")]
        GenericDeviceControls = 0x0006,

        [Description("Keyboard/Keypad")]
        [UsagePage(typeof(UsageKeyboard_Keypad))]
        Keyboard_Keypad = 0x0007,

        [Description("LEDs")]
        [UsagePage(typeof(UsageLEDs))]
        LEDs = 0x0008,

        [Description("Buttons")]
        [UsagePage(typeof(UsageButtons))]
        Button = 0x0009,

        [Description("Ordinal")]
        Ordinal = 0x000A,

        [Description("Telephony")]
        Telephony = 0x000B,

        [Description("Consumer")]
        Consumer = 0x000C,

        [Description("Digitizer")]
        Digitizer = 0x000D,

        // reserved 0x000E

        [Description("PID Page")]
        PIDPage = 0x000F,

        [Description("Unicode")]
        Unicode = 0x0010,

        // reserved 0x0011 - 0x0013

        [Description("Alphanumeric Display")]
        AlphanumericDisplay = 0x0014,

        // reserved 0x0015 - 0x003F

        [Description("Medical Instruments")]
        Medical_Instruments = 0x0040,

        // reserved 0x0041 - 0x007F

        [Description("Monitor Pages #0")]
        MonitorPages_0 = 0x0080,

        [Description("Monitor Pages #1")]
        MonitorPages_1 = 0x0081,

        [Description("Monitor Pages #2")]
        MonitorPages_2 = 0x0082,

        [Description("Monitor Pages #3")]
        MonitorPages_3 = 0x0083,

        [Description("Power Pages #0")]
        PowerPages_0 = 0x0084,

        [Description("Power Pages #1")]
        PowerPages_1 = 0x0085,

        [Description("Power Pages #2")]
        PowerPages_2 = 0x0086,

        [Description("Power Pages #3")]
        PowerPages_3 = 0x0087,

        // reserved 0x0088 - 0x008B

        [Description("Bar Code Scanner Page")]
        BarCodeScannerPage = 0x008C,

        [Description("Scale Page")]
        ScalePage = 0x008D,

        [Description("Magnetic Stripe Reading (MSR) Devices")]
        MagneticStripeReadingDevices = 0x008E,

        [Description("Reserved Point of Sale Page")]
        ReservedPointofSalePage = 0x008F,

        [Description("Camera Control Page")]
        CameraControlPage = 0x0090,

        [Description("Arcade Page")]
        ArcadePage = 0x0091,

        // reserved 0x0092- 0xFEFF

        [Description("Vendor Defined")]
        VendorDefined = 0xFF00,

        // VendorDefined 0xFF00 - 0xFFFF
    }
}
