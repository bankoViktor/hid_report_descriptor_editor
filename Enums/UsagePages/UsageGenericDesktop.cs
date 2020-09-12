using HID_Report_Descriptor_Editor.Attributes;
using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums.UsagePages
{
    public enum UsageGenericDesktop
    {
        // ширина 2 байта
        [Description("Undefined")]
        Undefined = 0x0000,

        [Description("Pointer")]
        [UsageType("CP")]
        Pointer = 0x0001,

        [Description("Mouse")]
        [UsageType("CA")]
        Mouse = 0x0002,

        // reserved 0x0003

        [Description("Joystick")]
        [UsageType("CA")]
        Joystick = 0x0004,

        [Description("Game Pad")]
        [UsageType("CA")]
        GamePad = 0x0005,

        [Description("Keyboard")]
        [UsageType("CA")]
        Keyboard = 0x0006,

        [Description("Keypad")]
        [UsageType("CA")]
        Keypad = 0x0007,

        [Description("Multi-axis Controller")]
        [UsageType("CA")]
        Multi_axisController = 0x0008,

        [Description("Tablet PC System Controls")]
        [UsageType("CA")]
        Ordinal = 0x0009,

        // reserved 0x000A - 0x002F

        [Description("X")]
        [UsageType("DV")]
        X = 0x0030,

        [Description("Y")]
        [UsageType("DV")]
        Y = 0x0031,

        [Description("Z")]
        [UsageType("DV")]
        Z = 0x0032,

        [Description("Rx")]
        [UsageType("DV")]
        Rx = 0x0033,

        [Description("Ry")]
        [UsageType("DV")]
        Ry = 0x0034,

        [Description("Rz")]
        [UsageType("DV")]
        Rz = 0x0035,

        [Description("Slider")]
        [UsageType("DV")]
        Slider = 0x0036,

        [Description("Dial")]
        [UsageType("DV")]
        Dial = 0x0037,

        [Description("Wheel")]
        [UsageType("DV")]
        Wheel = 0x0038,

        [Description("Hat Switch")]
        [UsageType("DV")]
        HatSwitch = 0x0039,

        [Description("Counted Buffer")]
        [UsageType("CL")]
        CountedBuffer = 0x003A,

        [Description("Byte Count")]
        [UsageType("DV")]
        ByteCount = 0x003B,

        [Description("Motion Wakeup")]
        [UsageType("OSC")]
        MotionWakeup = 0x003C,

        [Description("Start")]
        [UsageType("OOC")]
        Start = 0x003D,

        [Description("Select")]
        [UsageType("OOC")]
        Select = 0x003E,

        // reserved 0x003F

        [Description("Vx")]
        [UsageType("DV")]
        Vx = 0x0040,

        [Description("Vy")]
        [UsageType("DV")]
        Vy = 0x0041,

        [Description("Vz")]
        [UsageType("DV")]
        Vz = 0x0042,

        [Description("Vbrx")]
        [UsageType("DV")]
        Vbrx = 0x0043,

        [Description("Vbry")]
        [UsageType("DV")]
        Vbry = 0x0044,

        [Description("Vbrz")]
        [UsageType("DV")]
        Vbrz = 0x0045,

        [Description("Vno")]
        [UsageType("DV")]
        Vno = 0x0046,

        [Description("Feature Notification")]
        [UsageType("DV" + UsageTypeAttribute.Separator + "DF")]
        FeatureNotification = 0x0047,

        [Description("Resolution Multiplier")]
        [UsageType("DV")]
        ResolutionMultiplier = 0x0048,

        // reserved 0x0049 - 0x007F

        [Description("Resolution Multiplier")]
        [UsageType("CA")]
        SystemControl = 0x0080,

        // TODO дописать Usage Generic Desktop

        // reserved 0x00B8 - 0xFFFF
    }
}
