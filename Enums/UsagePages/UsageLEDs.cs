using HID_Report_Descriptor_Editor.Attributes;
using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums.UsagePages
{
    public enum UsageLEDs
    {
        // ширина 2 байта
        [Description("Undefined")]
        Undefined = 0x0000,

        [Description("Num Lock")]
        [UsageType("OOC")]
        NumLock = 0x0001,

        [Description("Caps Lock")]
        [UsageType("OOC")]
        CapsLock = 0x0002,

        [Description("Scroll Lock")]
        [UsageType("OOC")]
        ScrollLock = 0x0003,

        [Description("Compose")]
        [UsageType("OOC")]
        Compose = 0x0004,

        [Description("Kana")]
        [UsageType("OOC")]
        Kana = 0x0005,

        [Description("Power")]
        [UsageType("OOC")]
        Power = 0x0006,

        [Description("Shift")]
        [UsageType("OOC")]
        Shift = 0x0007,

        [Description("Do not disturb")]
        [UsageType("OOC")]
        DoNotDisturb = 0x0008,

        [Description("Mute")]
        [UsageType("OOC")]
        Mute = 0x0009,

        [Description("Tone Enable")]
        [UsageType("OOC")]
        ToneEnable = 0x000A,

        [Description("High Cut Filter")]
        [UsageType("OOC")]
        HighCutFilter = 0x000B,

        [Description("Low Cut Filter")]
        [UsageType("OOC")]
        LowCutFilter = 0x000C,

        [Description("Equalizer Enable")]
        [UsageType("OOC")]
        EqualizerEnable = 0x000D,

        [Description("Sound Field On")]
        [UsageType("OOC")]
        SoundFieldOn = 0x000E,

        [Description("Surround On")]
        [UsageType("OOC")]
        SurroundOn = 0x000F,

        [Description("Repeat")]
        [UsageType("OOC")]
        Repeat = 0x0010,

        [Description("Stereo")]
        [UsageType("OOC")]
        Stereo = 0x0011,

        [Description("Sampling Rate Detect")]
        [UsageType("OOC")]
        SamplingRateDetect = 0x0012,

        [Description("Spining")]
        [UsageType("OOC")]
        Spining = 0x0013,

        [Description("CAV")]
        [UsageType("OOC")]
        CAV = 0x0014,

        [Description("CLV")]
        [UsageType("OOC")]
        CLV = 0x0015,

        [Description("Recording Format Detect")]
        [UsageType("OOC")]
        RecordingFormatDetect = 0x0016,

        [Description("Off-Hook")]
        [UsageType("OOC")]
        Off_Hook = 0x0017,

        [Description("Ring")]
        [UsageType("OOC")]
        Ring = 0x0018,

        [Description("Message Waiting")]
        [UsageType("OOC")]
        MessageWaiting = 0x0019,

        [Description("Data Mode")]
        [UsageType("OOC")]
        DataMode = 0x001A,

        [Description("Battery Operation")]
        [UsageType("OOC")]
        BatteryOperation = 0x001B,

        [Description("Battery OK")]
        [UsageType("OOC")]
        BatteryOK = 0x001C,

        [Description("Battery Low")]
        [UsageType("OOC")]
        BatteryLow = 0x001D,

        [Description("Speaker")]
        [UsageType("OOC")]
        Speaker = 0x001E,

        [Description("Head Set")]
        [UsageType("OOC")]
        HeadSet = 0x001F,

        [Description("Hold")]
        [UsageType("OOC")]
        Hold = 0x0020,

        [Description("Microphone")]
        [UsageType("OOC")]
        Microphone = 0x0021,

        [Description("Coverage")]
        [UsageType("OOC")]
        Coverage = 0x0022,

        [Description("Night Mode")]
        [UsageType("OOC")]
        NightMode = 0x0023,

        [Description("Send Calls")]
        [UsageType("OOC")]
        SendCalls = 0x0024,

        [Description("Call Pickup")]
        [UsageType("OOC")]
        CallPickup = 0x0025,

        [Description("Conference")]
        [UsageType("OOC")]
        Conference = 0x0026,

        [Description("Stand-by")]
        [UsageType("OOC")]
        StandBy = 0x0027,

        [Description("Camera On")]
        [UsageType("OOC")]
        CameraOn = 0x0028,

        [Description("Camera Off")]
        [UsageType("OOC")]
        CameraOff = 0x0029,

        [Description("On-Line")]
        [UsageType("OOC")]
        OnLine = 0x002A,

        [Description("Off-Line")]
        [UsageType("OOC")]
        OffLine = 0x002B,

        [Description("Busy")]
        [UsageType("OOC")]
        Busy = 0x002C,

        [Description("Ready")]
        [UsageType("OOC")]
        Ready = 0x002D,

        [Description("Paper-Out")]
        [UsageType("OOC")]
        PaperOut = 0x002E,

        [Description("Paper-Jam")]
        [UsageType("OOC")]
        PaperJam = 0x002F,

        [Description("Remote")]
        [UsageType("OOC")]
        Remote = 0x0030,

        [Description("Forward")]
        [UsageType("OOC")]
        Forward = 0x0031,

        [Description("Reverse")]
        [UsageType("OOC")]
        Reverse = 0x0032,

        [Description("Stop")]
        [UsageType("OOC")]
        Stop = 0x0033,

        [Description("Rewind")]
        [UsageType("OOC")]
        Rewind = 0x0034,

        [Description("Fast Forward")]
        [UsageType("OOC")]
        FastForward = 0x0035,

        [Description("Play")]
        [UsageType("OOC")]
        Play = 0x0036,

        [Description("Pause")]
        [UsageType("OOC")]
        Pause = 0x0037,

        [Description("Record")]
        [UsageType("OOC")]
        Record = 0x0038,

        [Description("Error")]
        [UsageType("OOC")]
        Error = 0x0039,

        [Description("Usage Selected Indicator")]
        [UsageType("US")]
        UsageSelectedIndicator = 0x003A,

        [Description("Usage In Use Indicator")]
        [UsageType("US")]
        UsageInUseIndicator = 0x003B,

        [Description("Usage Multi Mode Indicator")]
        [UsageType("UM")]
        UsageMultiModeIndicator = 0x003C,

        [Description("Indicator On")]
        [UsageType("Sel")]
        IndicatorOn = 0x003D,

        [Description("Indicator Flash")]
        [UsageType("Sel")]
        IndicatorFlash = 0x003E,

        [Description("Indicator Slow Blink")]
        [UsageType("Sel")]
        IndicatorSlowBlink = 0x003F,

        [Description("Indicator Fast Blink")]
        [UsageType("Sel")]
        IndicatorFastBlink = 0x0040,

        [Description("Indicator Off")]
        [UsageType("Sel")]
        IndicatorOff = 0x0041,

        [Description("Flash On Time")]
        [UsageType("DV")]
        FlashOnTime = 0x0042,

        [Description("Slow Blink On Time")]
        [UsageType("DV")]
        SlowBlinkOnTime = 0x0043,

        [Description("Slow Blink Off Time")]
        [UsageType("DV")]
        SlowBlinkOffTime = 0x0044,

        [Description("Fast Blink On Time")]
        [UsageType("DV")]
        FastBlinkOnTime = 0x0045,

        [Description("Fast Blink Off Time")]
        [UsageType("DV")]
        FastBlinkOffTime = 0x0046,

        [Description("Usage Indicator Color")]
        [UsageType("UM")]
        UsageIndicatorColor = 0x0047,

        [Description("Indicator Red")]
        [UsageType("Sel")]
        IndicatorRed = 0x0048,

        [Description("Indicator Green")]
        [UsageType("Sel")]
        IndicatorGreen = 0x0049,

        [Description("Indicator Amber")]
        [UsageType("Sel")]
        IndicatorAmber = 0x004A,

        [Description("Generic Indicator")]
        [UsageType("OOC")]
        GenericIndicator = 0x004B,

        [Description("System Suspend")]
        [UsageType("OOC")]
        SystemSuspend = 0x004C,

        [Description("External Power Connected")]
        [UsageType("OOC")]
        ExternalPowerConnected = 0x004D,

        // reserved 0x004E - 0xFFFF
    }
}
