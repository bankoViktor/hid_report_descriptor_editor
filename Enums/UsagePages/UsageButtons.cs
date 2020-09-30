using HID_Report_Descriptor_Editor.Attributes;
using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums.UsagePages
{
    public enum UsageButtons : ushort
    {
        [Description("No Button Pressed")]
        NoButtonPressed = 0x0000,

        [Description("Button 1")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_1 = 0x0001,


        [Description("Button 2")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_2 = 0x0002,


        [Description("Button 3")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_3 = 0x0003,


        [Description("Button 4")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_4 = 0x0004,


        [Description("Button 5")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_5 = 0x0005,


        [Description("Button 6")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_6 = 0x0006,


        [Description("Button 7")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_7 = 0x0007,


        [Description("Button 8")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_8 = 0x0008,


        [Description("Button 9")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_9 = 0x0009,

        [Description("Button 10")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_10 = 0x000A,

        [Description("Button 11")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_11 = 0x000B,

        [Description("Button 12")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_12 = 0x000C,

        [Description("Button 13")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_13 = 0x000D,

        [Description("Button 14")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_14 = 0x000E,

        [Description("Button 15")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_15 = 0x000F,

        [Description("Button 16")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_16 = 0x0010,

        [Description("Button 17")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_17 = 0x0011,

        [Description("Button 18")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_18 = 0x0012,

        [Description("Button 19")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_19 = 0x0013,

        [Description("Button 20")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_20 = 0x0014,

        [Description("Button 21")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_21 = 0x0015,

        [Description("Button 22")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_22 = 0x0016,

        [Description("Button 23")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_23 = 0x0017,

        [Description("Button 24")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_24 = 0x0018,

        [Description("Button 25")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_25 = 0x0019,

        [Description("Button 26")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_26 = 0x001A,

        [Description("Button 27")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_27 = 0x001B,

        [Description("Button 28")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_28 = 0x001C,

        [Description("Button 29")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_29 = 0x001D,

        [Description("Button 30")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_30 = 0x001E,

        [Description("Button 31")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_31 = 0x001F,

        [Description("Button 32")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_32 = 0x0020,

        [Description("Button 33")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_33 = 0x0021,

        [Description("Button 34")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_34 = 0x0022,

        [Description("Button 35")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_35 = 0x0023,

        [Description("Button 36")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_36 = 0x0024,

        [Description("Button 37")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_37 = 0x0025,

        [Description("Button 38")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_38 = 0x0026,

        [Description("Button 39")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_39 = 0x0027,

        [Description("Button 40")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_40 = 0x0028,

        [Description("Button 41")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_41 = 0x0029,

        [Description("Button 42")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_42 = 0x002A,

        [Description("Button 43")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_43 = 0x002B,

        [Description("Button 44")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_44 = 0x002C,

        [Description("Button 45")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_45 = 0x002D,

        [Description("Button 46")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_46 = 0x002E,

        [Description("Button 47")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_47 = 0x002F,

        [Description("Button 48")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_48 = 0x0030,

        [Description("Button 49")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_49 = 0x0031,

        [Description("Button 50")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_50 = 0x0032,

        [Description("Button 51")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_51 = 0x0033,

        [Description("Button 52")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_52 = 0x0034,

        [Description("Button 53")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_53 = 0x0035,

        [Description("Button 54")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_54 = 0x0036,

        [Description("Button 55")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_55 = 0x0037,

        [Description("Button 56")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_56 = 0x0038,

        [Description("Button 57")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_57 = 0x0039,

        [Description("Button 58")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_58 = 0x003A,

        [Description("Button 59")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_59 = 0x003B,

        [Description("Button 60")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_60 = 0x003C,

        [Description("Button 61")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_61 = 0x003D,

        [Description("Button 62")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_62 = 0x003E,

        [Description("Button 63")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_63 = 0x003F,

        [Description("Button 64")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_64 = 0x0040,

        [Description("Button 65")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_65 = 0x0041,

        [Description("Button 66")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_66 = 0x0042,

        [Description("Button 67")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_67 = 0x0043,

        [Description("Button 68")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_68 = 0x0044,

        [Description("Button 69")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_69 = 0x0045,

        [Description("Button 70")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_70 = 0x0046,

        [Description("Button 71")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_71 = 0x0047,

        [Description("Button 72")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_72 = 0x0048,

        [Description("Button 73")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_73 = 0x0049,

        [Description("Button 74")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_74 = 0x004A,

        [Description("Button 75")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_75 = 0x004B,

        [Description("Button 76")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_76 = 0x004C,

        [Description("Button 77")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_77 = 0x004D,

        [Description("Button 78")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_78 = 0x004E,

        [Description("Button 79")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_79 = 0x004F,

        [Description("Button 80")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_80 = 0x0050,

        [Description("Button 81")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_81 = 0x0051,

        [Description("Button 82")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_82 = 0x0052,

        [Description("Button 83")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_83 = 0x0053,

        [Description("Button 84")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_84 = 0x0054,

        [Description("Button 85")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_85 = 0x0055,

        [Description("Button 86")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_86 = 0x0056,

        [Description("Button 87")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_87 = 0x0057,

        [Description("Button 88")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_88 = 0x0058,

        [Description("Button 89")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_89 = 0x0059,

        [Description("Button 90")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_90 = 0x005A,

        [Description("Button 91")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_91 = 0x005B,

        [Description("Button 92")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_92 = 0x005C,

        [Description("Button 93")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_93 = 0x005D,

        [Description("Button 94")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_94 = 0x005E,

        [Description("Button 95")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_95 = 0x005F,

        [Description("Button 96")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_96 = 0x0060,

        [Description("Button 97")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_97 = 0x0061,

        [Description("Button 98")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_98 = 0x0062,

        [Description("Button 99")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_99 = 0x0063,

        [Description("Button 100")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_100 = 0x0064,

        [Description("Button 101")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_101 = 0x0065,

        [Description("Button 102")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_102 = 0x0066,

        [Description("Button 103")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_103 = 0x0067,

        [Description("Button 104")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_104 = 0x0068,

        [Description("Button 105")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_105 = 0x0069,

        [Description("Button 106")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_106 = 0x006A,

        [Description("Button 107")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_107 = 0x006B,

        [Description("Button 108")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_108 = 0x006C,

        [Description("Button 109")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_109 = 0x006D,

        [Description("Button 110")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_110 = 0x006E,

        [Description("Button 111")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_111 = 0x006F,

        [Description("Button 112")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_112 = 0x0070,

        [Description("Button 113")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_113 = 0x0071,

        [Description("Button 114")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_114 = 0x0072,

        [Description("Button 115")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_115 = 0x0073,

        [Description("Button 116")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_116 = 0x0074,

        [Description("Button 117")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_117 = 0x0075,

        [Description("Button 118")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_118 = 0x0076,

        [Description("Button 119")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_119 = 0x0077,

        [Description("Button 120")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_120 = 0x0078,

        [Description("Button 121")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_121 = 0x0079,

        [Description("Button 122")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_122 = 0x007A,

        [Description("Button 123")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_123 = 0x007B,

        [Description("Button 124")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_124 = 0x007C,

        [Description("Button 125")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_125 = 0x007D,

        [Description("Button 126")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_126 = 0x007E,

        [Description("Button 127")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_127 = 0x007F,

        [Description("Button 128")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_128 = 0x0080,

        [Description("Button 129")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_129 = 0x0081,

        [Description("Button 130")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_130 = 0x0082,

        [Description("Button 131")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_131 = 0x0083,

        [Description("Button 132")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_132 = 0x0084,

        [Description("Button 133")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_133 = 0x0085,

        [Description("Button 134")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_134 = 0x0086,

        [Description("Button 135")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_135 = 0x0087,

        [Description("Button 136")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_136 = 0x0088,

        [Description("Button 137")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_137 = 0x0089,

        [Description("Button 138")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_138 = 0x008A,

        [Description("Button 139")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_139 = 0x008B,

        [Description("Button 140")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_140 = 0x008C,

        [Description("Button 141")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_141 = 0x008D,

        [Description("Button 142")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_142 = 0x008E,

        [Description("Button 143")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_143 = 0x008F,

        [Description("Button 144")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_144 = 0x0090,

        [Description("Button 145")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_145 = 0x0091,

        [Description("Button 146")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_146 = 0x0092,

        [Description("Button 147")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_147 = 0x0093,

        [Description("Button 148")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_148 = 0x0094,

        [Description("Button 149")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_149 = 0x0095,

        [Description("Button 150")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_150 = 0x0096,

        [Description("Button 151")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_151 = 0x0097,

        [Description("Button 152")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_152 = 0x0098,

        [Description("Button 153")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_153 = 0x0099,

        [Description("Button 154")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_154 = 0x009A,

        [Description("Button 155")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_155 = 0x009B,

        [Description("Button 156")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_156 = 0x009C,

        [Description("Button 157")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_157 = 0x009D,

        [Description("Button 158")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_158 = 0x009E,

        [Description("Button 159")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_159 = 0x009F,

        [Description("Button 160")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_160 = 0x00A0,

        [Description("Button 161")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_161 = 0x00A1,

        [Description("Button 162")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_162 = 0x00A2,

        [Description("Button 163")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_163 = 0x00A3,

        [Description("Button 164")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_164 = 0x00A4,

        [Description("Button 165")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_165 = 0x00A5,

        [Description("Button 166")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_166 = 0x00A6,

        [Description("Button 167")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_167 = 0x00A7,

        [Description("Button 168")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_168 = 0x00A8,

        [Description("Button 169")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_169 = 0x00A9,

        [Description("Button 170")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_170 = 0x00AA,

        [Description("Button 171")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_171 = 0x00AB,

        [Description("Button 172")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_172 = 0x00AC,

        [Description("Button 173")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_173 = 0x00AD,

        [Description("Button 174")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_174 = 0x00AE,

        [Description("Button 175")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_175 = 0x00AF,

        [Description("Button 176")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_176 = 0x00B0,

        [Description("Button 177")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_177 = 0x00B1,

        [Description("Button 178")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_178 = 0x00B2,

        [Description("Button 179")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_179 = 0x00B3,

        [Description("Button 180")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_180 = 0x00B4,

        [Description("Button 181")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_181 = 0x00B5,

        [Description("Button 182")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_182 = 0x00B6,

        [Description("Button 183")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_183 = 0x00B7,

        [Description("Button 184")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_184 = 0x00B8,

        [Description("Button 185")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_185 = 0x00B9,

        [Description("Button 186")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_186 = 0x00BA,

        [Description("Button 187")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_187 = 0x00BB,

        [Description("Button 188")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_188 = 0x00BC,

        [Description("Button 189")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_189 = 0x00BD,

        [Description("Button 190")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_190 = 0x00BE,

        [Description("Button 191")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_191 = 0x00BF,

        [Description("Button 192")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_192 = 0x00C0,

        [Description("Button 193")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_193 = 0x00C1,

        [Description("Button 194")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_194 = 0x00C2,

        [Description("Button 195")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_195 = 0x00C3,

        [Description("Button 196")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_196 = 0x00C4,

        [Description("Button 197")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_197 = 0x00C5,

        [Description("Button 198")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_198 = 0x00C6,

        [Description("Button 199")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_199 = 0x00C7,

        [Description("Button 200")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_200 = 0x00C8,

        [Description("Button 201")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_201 = 0x00C9,

        [Description("Button 202")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_202 = 0x00CA,

        [Description("Button 203")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_203 = 0x00CB,

        [Description("Button 204")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_204 = 0x00CC,

        [Description("Button 205")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_205 = 0x00CD,

        [Description("Button 206")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_206 = 0x00CE,

        [Description("Button 207")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_207 = 0x00CF,

        [Description("Button 208")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_208 = 0x00D0,

        [Description("Button 209")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_209 = 0x00D1,

        [Description("Button 210")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_210 = 0x00D2,

        [Description("Button 211")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_211 = 0x00D3,

        [Description("Button 212")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_212 = 0x00D4,

        [Description("Button 213")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_213 = 0x00D5,

        [Description("Button 214")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_214 = 0x00D6,

        [Description("Button 215")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_215 = 0x00D7,

        [Description("Button 216")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_216 = 0x00D8,

        [Description("Button 217")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_217 = 0x00D9,

        [Description("Button 218")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_218 = 0x00DA,

        [Description("Button 219")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_219 = 0x00DB,

        [Description("Button 220")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_220 = 0x00DC,

        [Description("Button 221")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_221 = 0x00DD,

        [Description("Button 222")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_222 = 0x00DE,

        [Description("Button 223")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_223 = 0x00DF,

        [Description("Button 224")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_224 = 0x00E0,

        [Description("Button 225")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_225 = 0x00E1,

        [Description("Button 226")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_226 = 0x00E2,

        [Description("Button 227")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_227 = 0x00E3,

        [Description("Button 228")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_228 = 0x00E4,

        [Description("Button 229")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_229 = 0x00E5,

        [Description("Button 230")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_230 = 0x00E6,

        [Description("Button 231")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_231 = 0x00E7,

        [Description("Button 232")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_232 = 0x00E8,

        [Description("Button 233")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_233 = 0x00E9,

        [Description("Button 234")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_234 = 0x00EA,

        [Description("Button 235")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_235 = 0x00EB,

        [Description("Button 236")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_236 = 0x00EC,

        [Description("Button 237")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_237 = 0x00ED,

        [Description("Button 238")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_238 = 0x00EE,

        [Description("Button 239")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_239 = 0x00EF,

        [Description("Button 240")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_240 = 0x00F0,

        [Description("Button 241")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_241 = 0x00F1,

        [Description("Button 242")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_242 = 0x00F2,

        [Description("Button 243")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_243 = 0x00F3,

        [Description("Button 244")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_244 = 0x00F4,

        [Description("Button 245")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_245 = 0x00F5,

        [Description("Button 246")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_246 = 0x00F6,

        [Description("Button 247")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_247 = 0x00F7,

        [Description("Button 248")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_248 = 0x00F8,

        [Description("Button 249")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_249 = 0x00F9,

        [Description("Button 250")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_250 = 0x00FA,

        [Description("Button 251")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_251 = 0x00FB,

        [Description("Button 252")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_252 = 0x00FC,

        [Description("Button 253")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_253 = 0x00FD,

        [Description("Button 254")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_254 = 0x00FE,

        [Description("Button 255")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_255 = 0x00FF,

        [Description("Button 256")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_256 = 0x0100,

        [Description("Button 257")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_257 = 0x0101,

        [Description("Button 258")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_258 = 0x0102,

        [Description("Button 259")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_259 = 0x0103,

        [Description("Button 260")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_260 = 0x0104,

        [Description("Button 261")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_261 = 0x0105,

        [Description("Button 262")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_262 = 0x0106,

        [Description("Button 263")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_263 = 0x0107,

        [Description("Button 264")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_264 = 0x0108,

        [Description("Button 265")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_265 = 0x0109,

        [Description("Button 266")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_266 = 0x010A,

        [Description("Button 267")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_267 = 0x010B,

        [Description("Button 268")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_268 = 0x010C,

        [Description("Button 269")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_269 = 0x010D,

        [Description("Button 270")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_270 = 0x010E,

        [Description("Button 271")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_271 = 0x010F,

        [Description("Button 272")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_272 = 0x0110,

        [Description("Button 273")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_273 = 0x0111,

        [Description("Button 274")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_274 = 0x0112,

        [Description("Button 275")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_275 = 0x0113,

        [Description("Button 276")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_276 = 0x0114,

        [Description("Button 277")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_277 = 0x0115,

        [Description("Button 278")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_278 = 0x0116,

        [Description("Button 279")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_279 = 0x0117,

        [Description("Button 280")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_280 = 0x0118,

        [Description("Button 281")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_281 = 0x0119,

        [Description("Button 282")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_282 = 0x011A,

        [Description("Button 283")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_283 = 0x011B,

        [Description("Button 284")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_284 = 0x011C,

        [Description("Button 285")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_285 = 0x011D,

        [Description("Button 286")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_286 = 0x011E,

        [Description("Button 287")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_287 = 0x011F,

        [Description("Button 288")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_288 = 0x0120,

        [Description("Button 289")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_289 = 0x0121,

        [Description("Button 290")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_290 = 0x0122,

        [Description("Button 291")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_291 = 0x0123,

        [Description("Button 292")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_292 = 0x0124,

        [Description("Button 293")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_293 = 0x0125,

        [Description("Button 294")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_294 = 0x0126,

        [Description("Button 295")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_295 = 0x0127,

        [Description("Button 296")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_296 = 0x0128,

        [Description("Button 297")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_297 = 0x0129,

        [Description("Button 298")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_298 = 0x012A,

        [Description("Button 299")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_299 = 0x012B,

        [Description("Button 300")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_300 = 0x012C,

        [Description("Button 301")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_301 = 0x012D,

        [Description("Button 302")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_302 = 0x012E,

        [Description("Button 303")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_303 = 0x012F,

        [Description("Button 304")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_304 = 0x0130,

        [Description("Button 305")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_305 = 0x0131,

        [Description("Button 306")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_306 = 0x0132,

        [Description("Button 307")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_307 = 0x0133,

        [Description("Button 308")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_308 = 0x0134,

        [Description("Button 309")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_309 = 0x0135,

        [Description("Button 310")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_310 = 0x0136,

        [Description("Button 311")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_311 = 0x0137,

        [Description("Button 312")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_312 = 0x0138,

        [Description("Button 313")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_313 = 0x0139,

        [Description("Button 314")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_314 = 0x013A,

        [Description("Button 315")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_315 = 0x013B,

        [Description("Button 316")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_316 = 0x013C,

        [Description("Button 317")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_317 = 0x013D,

        [Description("Button 318")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_318 = 0x013E,

        [Description("Button 319")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_319 = 0x013F,

        [Description("Button 320")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_320 = 0x0140,

        [Description("Button 321")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_321 = 0x0141,

        [Description("Button 322")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_322 = 0x0142,

        [Description("Button 323")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_323 = 0x0143,

        [Description("Button 324")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_324 = 0x0144,

        [Description("Button 325")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_325 = 0x0145,

        [Description("Button 326")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_326 = 0x0146,

        [Description("Button 327")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_327 = 0x0147,

        [Description("Button 328")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_328 = 0x0148,

        [Description("Button 329")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_329 = 0x0149,

        [Description("Button 330")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_330 = 0x014A,

        [Description("Button 331")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_331 = 0x014B,

        [Description("Button 332")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_332 = 0x014C,

        [Description("Button 333")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_333 = 0x014D,

        [Description("Button 334")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_334 = 0x014E,

        [Description("Button 335")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_335 = 0x014F,

        [Description("Button 336")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_336 = 0x0150,

        [Description("Button 337")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_337 = 0x0151,

        [Description("Button 338")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_338 = 0x0152,

        [Description("Button 339")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_339 = 0x0153,

        [Description("Button 340")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_340 = 0x0154,

        [Description("Button 341")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_341 = 0x0155,

        [Description("Button 342")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_342 = 0x0156,

        [Description("Button 343")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_343 = 0x0157,

        [Description("Button 344")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_344 = 0x0158,

        [Description("Button 345")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_345 = 0x0159,

        [Description("Button 346")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_346 = 0x015A,

        [Description("Button 347")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_347 = 0x015B,

        [Description("Button 348")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_348 = 0x015C,

        [Description("Button 349")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_349 = 0x015D,

        [Description("Button 350")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_350 = 0x015E,

        [Description("Button 351")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_351 = 0x015F,

        [Description("Button 352")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_352 = 0x0160,

        [Description("Button 353")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_353 = 0x0161,

        [Description("Button 354")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_354 = 0x0162,

        [Description("Button 355")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_355 = 0x0163,

        [Description("Button 356")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_356 = 0x0164,

        [Description("Button 357")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_357 = 0x0165,

        [Description("Button 358")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_358 = 0x0166,

        [Description("Button 359")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_359 = 0x0167,

        [Description("Button 360")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_360 = 0x0168,

        [Description("Button 361")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_361 = 0x0169,

        [Description("Button 362")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_362 = 0x016A,

        [Description("Button 363")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_363 = 0x016B,

        [Description("Button 364")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_364 = 0x016C,

        [Description("Button 365")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_365 = 0x016D,

        [Description("Button 366")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_366 = 0x016E,

        [Description("Button 367")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_367 = 0x016F,

        [Description("Button 368")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_368 = 0x0170,

        [Description("Button 369")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_369 = 0x0171,

        [Description("Button 370")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_370 = 0x0172,

        [Description("Button 371")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_371 = 0x0173,

        [Description("Button 372")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_372 = 0x0174,

        [Description("Button 373")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_373 = 0x0175,

        [Description("Button 374")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_374 = 0x0176,

        [Description("Button 375")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_375 = 0x0177,

        [Description("Button 376")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_376 = 0x0178,

        [Description("Button 377")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_377 = 0x0179,

        [Description("Button 378")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_378 = 0x017A,

        [Description("Button 379")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_379 = 0x017B,

        [Description("Button 380")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_380 = 0x017C,

        [Description("Button 381")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_381 = 0x017D,

        [Description("Button 382")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_382 = 0x017E,

        [Description("Button 383")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_383 = 0x017F,

        [Description("Button 384")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_384 = 0x0180,

        [Description("Button 385")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_385 = 0x0181,

        [Description("Button 386")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_386 = 0x0182,

        [Description("Button 387")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_387 = 0x0183,

        [Description("Button 388")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_388 = 0x0184,

        [Description("Button 389")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_389 = 0x0185,

        [Description("Button 390")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_390 = 0x0186,

        [Description("Button 391")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_391 = 0x0187,

        [Description("Button 392")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_392 = 0x0188,

        [Description("Button 393")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_393 = 0x0189,

        [Description("Button 394")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_394 = 0x018A,

        [Description("Button 395")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_395 = 0x018B,

        [Description("Button 396")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_396 = 0x018C,

        [Description("Button 397")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_397 = 0x018D,

        [Description("Button 398")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_398 = 0x018E,

        [Description("Button 399")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_399 = 0x018F,

        [Description("Button 400")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_400 = 0x0190,

        [Description("Button 401")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_401 = 0x0191,

        [Description("Button 402")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_402 = 0x0192,

        [Description("Button 403")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_403 = 0x0193,

        [Description("Button 404")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_404 = 0x0194,

        [Description("Button 405")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_405 = 0x0195,

        [Description("Button 406")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_406 = 0x0196,

        [Description("Button 407")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_407 = 0x0197,

        [Description("Button 408")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_408 = 0x0198,

        [Description("Button 409")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_409 = 0x0199,

        [Description("Button 410")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_410 = 0x019A,

        [Description("Button 411")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_411 = 0x019B,

        [Description("Button 412")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_412 = 0x019C,

        [Description("Button 413")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_413 = 0x019D,

        [Description("Button 414")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_414 = 0x019E,

        [Description("Button 415")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_415 = 0x019F,

        [Description("Button 416")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_416 = 0x01A0,

        [Description("Button 417")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_417 = 0x01A1,

        [Description("Button 418")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_418 = 0x01A2,

        [Description("Button 419")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_419 = 0x01A3,

        [Description("Button 420")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_420 = 0x01A4,

        [Description("Button 421")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_421 = 0x01A5,

        [Description("Button 422")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_422 = 0x01A6,

        [Description("Button 423")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_423 = 0x01A7,

        [Description("Button 424")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_424 = 0x01A8,

        [Description("Button 425")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_425 = 0x01A9,

        [Description("Button 426")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_426 = 0x01AA,

        [Description("Button 427")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_427 = 0x01AB,

        [Description("Button 428")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_428 = 0x01AC,

        [Description("Button 429")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_429 = 0x01AD,

        [Description("Button 430")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_430 = 0x01AE,

        [Description("Button 431")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_431 = 0x01AF,

        [Description("Button 432")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_432 = 0x01B0,

        [Description("Button 433")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_433 = 0x01B1,

        [Description("Button 434")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_434 = 0x01B2,

        [Description("Button 435")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_435 = 0x01B3,

        [Description("Button 436")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_436 = 0x01B4,

        [Description("Button 437")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_437 = 0x01B5,

        [Description("Button 438")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_438 = 0x01B6,

        [Description("Button 439")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_439 = 0x01B7,

        [Description("Button 440")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_440 = 0x01B8,

        [Description("Button 441")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_441 = 0x01B9,

        [Description("Button 442")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_442 = 0x01BA,

        [Description("Button 443")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_443 = 0x01BB,

        [Description("Button 444")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_444 = 0x01BC,

        [Description("Button 445")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_445 = 0x01BD,

        [Description("Button 446")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_446 = 0x01BE,

        [Description("Button 447")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_447 = 0x01BF,

        [Description("Button 448")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_448 = 0x01C0,

        [Description("Button 449")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_449 = 0x01C1,

        [Description("Button 450")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_450 = 0x01C2,

        [Description("Button 451")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_451 = 0x01C3,

        [Description("Button 452")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_452 = 0x01C4,

        [Description("Button 453")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_453 = 0x01C5,

        [Description("Button 454")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_454 = 0x01C6,

        [Description("Button 455")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_455 = 0x01C7,

        [Description("Button 456")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_456 = 0x01C8,

        [Description("Button 457")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_457 = 0x01C9,

        [Description("Button 458")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_458 = 0x01CA,

        [Description("Button 459")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_459 = 0x01CB,

        [Description("Button 460")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_460 = 0x01CC,

        [Description("Button 461")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_461 = 0x01CD,

        [Description("Button 462")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_462 = 0x01CE,

        [Description("Button 463")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_463 = 0x01CF,

        [Description("Button 464")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_464 = 0x01D0,

        [Description("Button 465")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_465 = 0x01D1,

        [Description("Button 466")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_466 = 0x01D2,

        [Description("Button 467")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_467 = 0x01D3,

        [Description("Button 468")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_468 = 0x01D4,

        [Description("Button 469")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_469 = 0x01D5,

        [Description("Button 470")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_470 = 0x01D6,

        [Description("Button 471")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_471 = 0x01D7,

        [Description("Button 472")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_472 = 0x01D8,

        [Description("Button 473")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_473 = 0x01D9,

        [Description("Button 474")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_474 = 0x01DA,

        [Description("Button 475")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_475 = 0x01DB,

        [Description("Button 476")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_476 = 0x01DC,

        [Description("Button 477")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_477 = 0x01DD,

        [Description("Button 478")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_478 = 0x01DE,

        [Description("Button 479")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_479 = 0x01DF,

        [Description("Button 480")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_480 = 0x01E0,

        [Description("Button 481")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_481 = 0x01E1,

        [Description("Button 482")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_482 = 0x01E2,

        [Description("Button 483")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_483 = 0x01E3,

        [Description("Button 484")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_484 = 0x01E4,

        [Description("Button 485")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_485 = 0x01E5,

        [Description("Button 486")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_486 = 0x01E6,

        [Description("Button 487")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_487 = 0x01E7,

        [Description("Button 488")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_488 = 0x01E8,

        [Description("Button 489")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_489 = 0x01E9,

        [Description("Button 490")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_490 = 0x01EA,

        [Description("Button 491")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_491 = 0x01EB,

        [Description("Button 492")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_492 = 0x01EC,

        [Description("Button 493")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_493 = 0x01ED,

        [Description("Button 494")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_494 = 0x01EE,

        [Description("Button 495")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_495 = 0x01EF,

        [Description("Button 496")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_496 = 0x01F0,

        [Description("Button 497")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_497 = 0x01F1,

        [Description("Button 498")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_498 = 0x01F2,

        [Description("Button 499")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_499 = 0x01F3,

        [Description("Button 500")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_500 = 0x01F4,

        [Description("Button 501")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_501 = 0x01F5,

        [Description("Button 502")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_502 = 0x01F6,

        [Description("Button 503")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_503 = 0x01F7,

        [Description("Button 504")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_504 = 0x01F8,

        [Description("Button 505")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_505 = 0x01F9,

        [Description("Button 506")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_506 = 0x01FA,

        [Description("Button 507")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_507 = 0x01FB,

        [Description("Button 508")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_508 = 0x01FC,

        [Description("Button 509")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_509 = 0x01FD,

        [Description("Button 510")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_510 = 0x01FE,

        [Description("Button 511")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_511 = 0x01FF,

        [Description("Button 512")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_512 = 0x0200,

        [Description("Button 513")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_513 = 0x0201,

        [Description("Button 514")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_514 = 0x0202,

        [Description("Button 515")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_515 = 0x0203,

        [Description("Button 516")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_516 = 0x0204,

        [Description("Button 517")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_517 = 0x0205,

        [Description("Button 518")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_518 = 0x0206,

        [Description("Button 519")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_519 = 0x0207,

        [Description("Button 520")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_520 = 0x0208,

        [Description("Button 521")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_521 = 0x0209,

        [Description("Button 522")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_522 = 0x020A,

        [Description("Button 523")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_523 = 0x020B,

        [Description("Button 524")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_524 = 0x020C,

        [Description("Button 525")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_525 = 0x020D,

        [Description("Button 526")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_526 = 0x020E,

        [Description("Button 527")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_527 = 0x020F,

        [Description("Button 528")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_528 = 0x0210,

        [Description("Button 529")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_529 = 0x0211,

        [Description("Button 530")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_530 = 0x0212,

        [Description("Button 531")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_531 = 0x0213,

        [Description("Button 532")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_532 = 0x0214,

        [Description("Button 533")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_533 = 0x0215,

        [Description("Button 534")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_534 = 0x0216,

        [Description("Button 535")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_535 = 0x0217,

        [Description("Button 536")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_536 = 0x0218,

        [Description("Button 537")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_537 = 0x0219,

        [Description("Button 538")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_538 = 0x021A,

        [Description("Button 539")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_539 = 0x021B,

        [Description("Button 540")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_540 = 0x021C,

        [Description("Button 541")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_541 = 0x021D,

        [Description("Button 542")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_542 = 0x021E,

        [Description("Button 543")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_543 = 0x021F,

        [Description("Button 544")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_544 = 0x0220,

        [Description("Button 545")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_545 = 0x0221,

        [Description("Button 546")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_546 = 0x0222,

        [Description("Button 547")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_547 = 0x0223,

        [Description("Button 548")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_548 = 0x0224,

        [Description("Button 549")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_549 = 0x0225,

        [Description("Button 550")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_550 = 0x0226,

        [Description("Button 551")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_551 = 0x0227,

        [Description("Button 552")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_552 = 0x0228,

        [Description("Button 553")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_553 = 0x0229,

        [Description("Button 554")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_554 = 0x022A,

        [Description("Button 555")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_555 = 0x022B,

        [Description("Button 556")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_556 = 0x022C,

        [Description("Button 557")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_557 = 0x022D,

        [Description("Button 558")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_558 = 0x022E,

        [Description("Button 559")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_559 = 0x022F,

        [Description("Button 560")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_560 = 0x0230,

        [Description("Button 561")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_561 = 0x0231,

        [Description("Button 562")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_562 = 0x0232,

        [Description("Button 563")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_563 = 0x0233,

        [Description("Button 564")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_564 = 0x0234,

        [Description("Button 565")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_565 = 0x0235,

        [Description("Button 566")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_566 = 0x0236,

        [Description("Button 567")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_567 = 0x0237,

        [Description("Button 568")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_568 = 0x0238,

        [Description("Button 569")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_569 = 0x0239,

        [Description("Button 570")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_570 = 0x023A,

        [Description("Button 571")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_571 = 0x023B,

        [Description("Button 572")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_572 = 0x023C,

        [Description("Button 573")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_573 = 0x023D,

        [Description("Button 574")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_574 = 0x023E,

        [Description("Button 575")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_575 = 0x023F,

        [Description("Button 576")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_576 = 0x0240,

        [Description("Button 577")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_577 = 0x0241,

        [Description("Button 578")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_578 = 0x0242,

        [Description("Button 579")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_579 = 0x0243,

        [Description("Button 580")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_580 = 0x0244,

        [Description("Button 581")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_581 = 0x0245,

        [Description("Button 582")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_582 = 0x0246,

        [Description("Button 583")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_583 = 0x0247,

        [Description("Button 584")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_584 = 0x0248,

        [Description("Button 585")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_585 = 0x0249,

        [Description("Button 586")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_586 = 0x024A,

        [Description("Button 587")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_587 = 0x024B,

        [Description("Button 588")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_588 = 0x024C,

        [Description("Button 589")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_589 = 0x024D,

        [Description("Button 590")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_590 = 0x024E,

        [Description("Button 591")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_591 = 0x024F,

        [Description("Button 592")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_592 = 0x0250,

        [Description("Button 593")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_593 = 0x0251,

        [Description("Button 594")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_594 = 0x0252,

        [Description("Button 595")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_595 = 0x0253,

        [Description("Button 596")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_596 = 0x0254,

        [Description("Button 597")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_597 = 0x0255,

        [Description("Button 598")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_598 = 0x0256,

        [Description("Button 599")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_599 = 0x0257,

        [Description("Button 600")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_600 = 0x0258,

        [Description("Button 601")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_601 = 0x0259,

        [Description("Button 602")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_602 = 0x025A,

        [Description("Button 603")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_603 = 0x025B,

        [Description("Button 604")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_604 = 0x025C,

        [Description("Button 605")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_605 = 0x025D,

        [Description("Button 606")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_606 = 0x025E,

        [Description("Button 607")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_607 = 0x025F,

        [Description("Button 608")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_608 = 0x0260,

        [Description("Button 609")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_609 = 0x0261,

        [Description("Button 610")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_610 = 0x0262,

        [Description("Button 611")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_611 = 0x0263,

        [Description("Button 612")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_612 = 0x0264,

        [Description("Button 613")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_613 = 0x0265,

        [Description("Button 614")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_614 = 0x0266,

        [Description("Button 615")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_615 = 0x0267,

        [Description("Button 616")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_616 = 0x0268,

        [Description("Button 617")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_617 = 0x0269,

        [Description("Button 618")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_618 = 0x026A,

        [Description("Button 619")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_619 = 0x026B,

        [Description("Button 620")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_620 = 0x026C,

        [Description("Button 621")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_621 = 0x026D,

        [Description("Button 622")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_622 = 0x026E,

        [Description("Button 623")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_623 = 0x026F,

        [Description("Button 624")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_624 = 0x0270,

        [Description("Button 625")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_625 = 0x0271,

        [Description("Button 626")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_626 = 0x0272,

        [Description("Button 627")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_627 = 0x0273,

        [Description("Button 628")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_628 = 0x0274,

        [Description("Button 629")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_629 = 0x0275,

        [Description("Button 630")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_630 = 0x0276,

        [Description("Button 631")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_631 = 0x0277,

        [Description("Button 632")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_632 = 0x0278,

        [Description("Button 633")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_633 = 0x0279,

        [Description("Button 634")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_634 = 0x027A,

        [Description("Button 635")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_635 = 0x027B,

        [Description("Button 636")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_636 = 0x027C,

        [Description("Button 637")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_637 = 0x027D,

        [Description("Button 638")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_638 = 0x027E,

        [Description("Button 639")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_639 = 0x027F,

        [Description("Button 640")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_640 = 0x0280,

        [Description("Button 641")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_641 = 0x0281,

        [Description("Button 642")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_642 = 0x0282,

        [Description("Button 643")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_643 = 0x0283,

        [Description("Button 644")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_644 = 0x0284,

        [Description("Button 645")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_645 = 0x0285,

        [Description("Button 646")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_646 = 0x0286,

        [Description("Button 647")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_647 = 0x0287,

        [Description("Button 648")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_648 = 0x0288,

        [Description("Button 649")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_649 = 0x0289,

        [Description("Button 650")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_650 = 0x028A,

        [Description("Button 651")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_651 = 0x028B,

        [Description("Button 652")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_652 = 0x028C,

        [Description("Button 653")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_653 = 0x028D,

        [Description("Button 654")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_654 = 0x028E,

        [Description("Button 655")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_655 = 0x028F,

        [Description("Button 656")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_656 = 0x0290,

        [Description("Button 657")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_657 = 0x0291,

        [Description("Button 658")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_658 = 0x0292,

        [Description("Button 659")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_659 = 0x0293,

        [Description("Button 660")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_660 = 0x0294,

        [Description("Button 661")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_661 = 0x0295,

        [Description("Button 662")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_662 = 0x0296,

        [Description("Button 663")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_663 = 0x0297,

        [Description("Button 664")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_664 = 0x0298,

        [Description("Button 665")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_665 = 0x0299,

        [Description("Button 666")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_666 = 0x029A,

        [Description("Button 667")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_667 = 0x029B,

        [Description("Button 668")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_668 = 0x029C,

        [Description("Button 669")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_669 = 0x029D,

        [Description("Button 670")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_670 = 0x029E,

        [Description("Button 671")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_671 = 0x029F,

        [Description("Button 672")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_672 = 0x02A0,

        [Description("Button 673")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_673 = 0x02A1,

        [Description("Button 674")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_674 = 0x02A2,

        [Description("Button 675")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_675 = 0x02A3,

        [Description("Button 676")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_676 = 0x02A4,

        [Description("Button 677")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_677 = 0x02A5,

        [Description("Button 678")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_678 = 0x02A6,

        [Description("Button 679")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_679 = 0x02A7,

        [Description("Button 680")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_680 = 0x02A8,

        [Description("Button 681")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_681 = 0x02A9,

        [Description("Button 682")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_682 = 0x02AA,

        [Description("Button 683")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_683 = 0x02AB,

        [Description("Button 684")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_684 = 0x02AC,

        [Description("Button 685")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_685 = 0x02AD,

        [Description("Button 686")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_686 = 0x02AE,

        [Description("Button 687")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_687 = 0x02AF,

        [Description("Button 688")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_688 = 0x02B0,

        [Description("Button 689")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_689 = 0x02B1,

        [Description("Button 690")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_690 = 0x02B2,

        [Description("Button 691")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_691 = 0x02B3,

        [Description("Button 692")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_692 = 0x02B4,

        [Description("Button 693")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_693 = 0x02B5,

        [Description("Button 694")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_694 = 0x02B6,

        [Description("Button 695")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_695 = 0x02B7,

        [Description("Button 696")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_696 = 0x02B8,

        [Description("Button 697")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_697 = 0x02B9,

        [Description("Button 698")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_698 = 0x02BA,

        [Description("Button 699")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_699 = 0x02BB,

        [Description("Button 700")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_700 = 0x02BC,

        [Description("Button 701")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_701 = 0x02BD,

        [Description("Button 702")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_702 = 0x02BE,

        [Description("Button 703")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_703 = 0x02BF,

        [Description("Button 704")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_704 = 0x02C0,

        [Description("Button 705")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_705 = 0x02C1,

        [Description("Button 706")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_706 = 0x02C2,

        [Description("Button 707")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_707 = 0x02C3,

        [Description("Button 708")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_708 = 0x02C4,

        [Description("Button 709")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_709 = 0x02C5,

        [Description("Button 710")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_710 = 0x02C6,

        [Description("Button 711")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_711 = 0x02C7,

        [Description("Button 712")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_712 = 0x02C8,

        [Description("Button 713")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_713 = 0x02C9,

        [Description("Button 714")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_714 = 0x02CA,

        [Description("Button 715")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_715 = 0x02CB,

        [Description("Button 716")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_716 = 0x02CC,

        [Description("Button 717")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_717 = 0x02CD,

        [Description("Button 718")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_718 = 0x02CE,

        [Description("Button 719")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_719 = 0x02CF,

        [Description("Button 720")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_720 = 0x02D0,

        [Description("Button 721")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_721 = 0x02D1,

        [Description("Button 722")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_722 = 0x02D2,

        [Description("Button 723")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_723 = 0x02D3,

        [Description("Button 724")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_724 = 0x02D4,

        [Description("Button 725")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_725 = 0x02D5,

        [Description("Button 726")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_726 = 0x02D6,

        [Description("Button 727")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_727 = 0x02D7,

        [Description("Button 728")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_728 = 0x02D8,

        [Description("Button 729")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_729 = 0x02D9,

        [Description("Button 730")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_730 = 0x02DA,

        [Description("Button 731")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_731 = 0x02DB,

        [Description("Button 732")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_732 = 0x02DC,

        [Description("Button 733")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_733 = 0x02DD,

        [Description("Button 734")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_734 = 0x02DE,

        [Description("Button 735")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_735 = 0x02DF,

        [Description("Button 736")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_736 = 0x02E0,

        [Description("Button 737")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_737 = 0x02E1,

        [Description("Button 738")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_738 = 0x02E2,

        [Description("Button 739")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_739 = 0x02E3,

        [Description("Button 740")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_740 = 0x02E4,

        [Description("Button 741")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_741 = 0x02E5,

        [Description("Button 742")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_742 = 0x02E6,

        [Description("Button 743")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_743 = 0x02E7,

        [Description("Button 744")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_744 = 0x02E8,

        [Description("Button 745")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_745 = 0x02E9,

        [Description("Button 746")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_746 = 0x02EA,

        [Description("Button 747")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_747 = 0x02EB,

        [Description("Button 748")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_748 = 0x02EC,

        [Description("Button 749")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_749 = 0x02ED,

        [Description("Button 750")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_750 = 0x02EE,

        [Description("Button 751")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_751 = 0x02EF,

        [Description("Button 752")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_752 = 0x02F0,

        [Description("Button 753")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_753 = 0x02F1,

        [Description("Button 754")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_754 = 0x02F2,

        [Description("Button 755")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_755 = 0x02F3,

        [Description("Button 756")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_756 = 0x02F4,

        [Description("Button 757")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_757 = 0x02F5,

        [Description("Button 758")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_758 = 0x02F6,

        [Description("Button 759")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_759 = 0x02F7,

        [Description("Button 760")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_760 = 0x02F8,

        [Description("Button 761")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_761 = 0x02F9,

        [Description("Button 762")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_762 = 0x02FA,

        [Description("Button 763")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_763 = 0x02FB,

        [Description("Button 764")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_764 = 0x02FC,

        [Description("Button 765")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_765 = 0x02FD,

        [Description("Button 766")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_766 = 0x02FE,

        [Description("Button 767")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_767 = 0x02FF,

        [Description("Button 768")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_768 = 0x0300,

        [Description("Button 769")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_769 = 0x0301,

        [Description("Button 770")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_770 = 0x0302,

        [Description("Button 771")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_771 = 0x0303,

        [Description("Button 772")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_772 = 0x0304,

        [Description("Button 773")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_773 = 0x0305,

        [Description("Button 774")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_774 = 0x0306,

        [Description("Button 775")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_775 = 0x0307,

        [Description("Button 776")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_776 = 0x0308,

        [Description("Button 777")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_777 = 0x0309,

        [Description("Button 778")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_778 = 0x030A,

        [Description("Button 779")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_779 = 0x030B,

        [Description("Button 780")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_780 = 0x030C,

        [Description("Button 781")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_781 = 0x030D,

        [Description("Button 782")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_782 = 0x030E,

        [Description("Button 783")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_783 = 0x030F,

        [Description("Button 784")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_784 = 0x0310,

        [Description("Button 785")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_785 = 0x0311,

        [Description("Button 786")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_786 = 0x0312,

        [Description("Button 787")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_787 = 0x0313,

        [Description("Button 788")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_788 = 0x0314,

        [Description("Button 789")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_789 = 0x0315,

        [Description("Button 790")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_790 = 0x0316,

        [Description("Button 791")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_791 = 0x0317,

        [Description("Button 792")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_792 = 0x0318,

        [Description("Button 793")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_793 = 0x0319,

        [Description("Button 794")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_794 = 0x031A,

        [Description("Button 795")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_795 = 0x031B,

        [Description("Button 796")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_796 = 0x031C,

        [Description("Button 797")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_797 = 0x031D,

        [Description("Button 798")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_798 = 0x031E,

        [Description("Button 799")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_799 = 0x031F,

        [Description("Button 800")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_800 = 0x0320,

        [Description("Button 801")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_801 = 0x0321,

        [Description("Button 802")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_802 = 0x0322,

        [Description("Button 803")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_803 = 0x0323,

        [Description("Button 804")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_804 = 0x0324,

        [Description("Button 805")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_805 = 0x0325,

        [Description("Button 806")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_806 = 0x0326,

        [Description("Button 807")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_807 = 0x0327,

        [Description("Button 808")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_808 = 0x0328,

        [Description("Button 809")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_809 = 0x0329,

        [Description("Button 810")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_810 = 0x032A,

        [Description("Button 811")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_811 = 0x032B,

        [Description("Button 812")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_812 = 0x032C,

        [Description("Button 813")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_813 = 0x032D,

        [Description("Button 814")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_814 = 0x032E,

        [Description("Button 815")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_815 = 0x032F,

        [Description("Button 816")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_816 = 0x0330,

        [Description("Button 817")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_817 = 0x0331,

        [Description("Button 818")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_818 = 0x0332,

        [Description("Button 819")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_819 = 0x0333,

        [Description("Button 820")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_820 = 0x0334,

        [Description("Button 821")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_821 = 0x0335,

        [Description("Button 822")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_822 = 0x0336,

        [Description("Button 823")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_823 = 0x0337,

        [Description("Button 824")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_824 = 0x0338,

        [Description("Button 825")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_825 = 0x0339,

        [Description("Button 826")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_826 = 0x033A,

        [Description("Button 827")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_827 = 0x033B,

        [Description("Button 828")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_828 = 0x033C,

        [Description("Button 829")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_829 = 0x033D,

        [Description("Button 830")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_830 = 0x033E,

        [Description("Button 831")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_831 = 0x033F,

        [Description("Button 832")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_832 = 0x0340,

        [Description("Button 833")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_833 = 0x0341,

        [Description("Button 834")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_834 = 0x0342,

        [Description("Button 835")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_835 = 0x0343,

        [Description("Button 836")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_836 = 0x0344,

        [Description("Button 837")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_837 = 0x0345,

        [Description("Button 838")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_838 = 0x0346,

        [Description("Button 839")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_839 = 0x0347,

        [Description("Button 840")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_840 = 0x0348,

        [Description("Button 841")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_841 = 0x0349,

        [Description("Button 842")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_842 = 0x034A,

        [Description("Button 843")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_843 = 0x034B,

        [Description("Button 844")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_844 = 0x034C,

        [Description("Button 845")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_845 = 0x034D,

        [Description("Button 846")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_846 = 0x034E,

        [Description("Button 847")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_847 = 0x034F,

        [Description("Button 848")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_848 = 0x0350,

        [Description("Button 849")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_849 = 0x0351,

        [Description("Button 850")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_850 = 0x0352,

        [Description("Button 851")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_851 = 0x0353,

        [Description("Button 852")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_852 = 0x0354,

        [Description("Button 853")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_853 = 0x0355,

        [Description("Button 854")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_854 = 0x0356,

        [Description("Button 855")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_855 = 0x0357,

        [Description("Button 856")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_856 = 0x0358,

        [Description("Button 857")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_857 = 0x0359,

        [Description("Button 858")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_858 = 0x035A,

        [Description("Button 859")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_859 = 0x035B,

        [Description("Button 860")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_860 = 0x035C,

        [Description("Button 861")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_861 = 0x035D,

        [Description("Button 862")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_862 = 0x035E,

        [Description("Button 863")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_863 = 0x035F,

        [Description("Button 864")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_864 = 0x0360,

        [Description("Button 865")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_865 = 0x0361,

        [Description("Button 866")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_866 = 0x0362,

        [Description("Button 867")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_867 = 0x0363,

        [Description("Button 868")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_868 = 0x0364,

        [Description("Button 869")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_869 = 0x0365,

        [Description("Button 870")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_870 = 0x0366,

        [Description("Button 871")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_871 = 0x0367,

        [Description("Button 872")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_872 = 0x0368,

        [Description("Button 873")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_873 = 0x0369,

        [Description("Button 874")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_874 = 0x036A,

        [Description("Button 875")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_875 = 0x036B,

        [Description("Button 876")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_876 = 0x036C,

        [Description("Button 877")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_877 = 0x036D,

        [Description("Button 878")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_878 = 0x036E,

        [Description("Button 879")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_879 = 0x036F,

        [Description("Button 880")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_880 = 0x0370,

        [Description("Button 881")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_881 = 0x0371,

        [Description("Button 882")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_882 = 0x0372,

        [Description("Button 883")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_883 = 0x0373,

        [Description("Button 884")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_884 = 0x0374,

        [Description("Button 885")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_885 = 0x0375,

        [Description("Button 886")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_886 = 0x0376,

        [Description("Button 887")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_887 = 0x0377,

        [Description("Button 888")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_888 = 0x0378,

        [Description("Button 889")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_889 = 0x0379,

        [Description("Button 890")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_890 = 0x037A,

        [Description("Button 891")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_891 = 0x037B,

        [Description("Button 892")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_892 = 0x037C,

        [Description("Button 893")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_893 = 0x037D,

        [Description("Button 894")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_894 = 0x037E,

        [Description("Button 895")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_895 = 0x037F,

        [Description("Button 896")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_896 = 0x0380,

        [Description("Button 897")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_897 = 0x0381,

        [Description("Button 898")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_898 = 0x0382,

        [Description("Button 899")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_899 = 0x0383,

        [Description("Button 900")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_900 = 0x0384,

        [Description("Button 901")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_901 = 0x0385,

        [Description("Button 902")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_902 = 0x0386,

        [Description("Button 903")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_903 = 0x0387,

        [Description("Button 904")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_904 = 0x0388,

        [Description("Button 905")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_905 = 0x0389,

        [Description("Button 906")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_906 = 0x038A,

        [Description("Button 907")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_907 = 0x038B,

        [Description("Button 908")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_908 = 0x038C,

        [Description("Button 909")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_909 = 0x038D,

        [Description("Button 910")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_910 = 0x038E,

        [Description("Button 911")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_911 = 0x038F,

        [Description("Button 912")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_912 = 0x0390,

        [Description("Button 913")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_913 = 0x0391,

        [Description("Button 914")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_914 = 0x0392,

        [Description("Button 915")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_915 = 0x0393,

        [Description("Button 916")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_916 = 0x0394,

        [Description("Button 917")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_917 = 0x0395,

        [Description("Button 918")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_918 = 0x0396,

        [Description("Button 919")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_919 = 0x0397,

        [Description("Button 920")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_920 = 0x0398,

        [Description("Button 921")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_921 = 0x0399,

        [Description("Button 922")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_922 = 0x039A,

        [Description("Button 923")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_923 = 0x039B,

        [Description("Button 924")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_924 = 0x039C,

        [Description("Button 925")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_925 = 0x039D,

        [Description("Button 926")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_926 = 0x039E,

        [Description("Button 927")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_927 = 0x039F,

        [Description("Button 928")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_928 = 0x03A0,

        [Description("Button 929")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_929 = 0x03A1,

        [Description("Button 930")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_930 = 0x03A2,

        [Description("Button 931")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_931 = 0x03A3,

        [Description("Button 932")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_932 = 0x03A4,

        [Description("Button 933")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_933 = 0x03A5,

        [Description("Button 934")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_934 = 0x03A6,

        [Description("Button 935")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_935 = 0x03A7,

        [Description("Button 936")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_936 = 0x03A8,

        [Description("Button 937")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_937 = 0x03A9,

        [Description("Button 938")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_938 = 0x03AA,

        [Description("Button 939")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_939 = 0x03AB,

        [Description("Button 940")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_940 = 0x03AC,

        [Description("Button 941")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_941 = 0x03AD,

        [Description("Button 942")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_942 = 0x03AE,

        [Description("Button 943")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_943 = 0x03AF,

        [Description("Button 944")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_944 = 0x03B0,

        [Description("Button 945")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_945 = 0x03B1,

        [Description("Button 946")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_946 = 0x03B2,

        [Description("Button 947")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_947 = 0x03B3,

        [Description("Button 948")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_948 = 0x03B4,

        [Description("Button 949")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_949 = 0x03B5,

        [Description("Button 950")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_950 = 0x03B6,

        [Description("Button 951")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_951 = 0x03B7,

        [Description("Button 952")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_952 = 0x03B8,

        [Description("Button 953")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_953 = 0x03B9,

        [Description("Button 954")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_954 = 0x03BA,

        [Description("Button 955")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_955 = 0x03BB,

        [Description("Button 956")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_956 = 0x03BC,

        [Description("Button 957")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_957 = 0x03BD,

        [Description("Button 958")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_958 = 0x03BE,

        [Description("Button 959")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_959 = 0x03BF,

        [Description("Button 960")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_960 = 0x03C0,

        [Description("Button 961")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_961 = 0x03C1,

        [Description("Button 962")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_962 = 0x03C2,

        [Description("Button 963")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_963 = 0x03C3,

        [Description("Button 964")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_964 = 0x03C4,

        [Description("Button 965")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_965 = 0x03C5,

        [Description("Button 966")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_966 = 0x03C6,

        [Description("Button 967")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_967 = 0x03C7,

        [Description("Button 968")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_968 = 0x03C8,

        [Description("Button 969")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_969 = 0x03C9,

        [Description("Button 970")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_970 = 0x03CA,

        [Description("Button 971")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_971 = 0x03CB,

        [Description("Button 972")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_972 = 0x03CC,

        [Description("Button 973")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_973 = 0x03CD,

        [Description("Button 974")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_974 = 0x03CE,

        [Description("Button 975")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_975 = 0x03CF,

        [Description("Button 976")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_976 = 0x03D0,

        [Description("Button 977")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_977 = 0x03D1,

        [Description("Button 978")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_978 = 0x03D2,

        [Description("Button 979")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_979 = 0x03D3,

        [Description("Button 980")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_980 = 0x03D4,

        [Description("Button 981")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_981 = 0x03D5,

        [Description("Button 982")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_982 = 0x03D6,

        [Description("Button 983")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_983 = 0x03D7,

        [Description("Button 984")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_984 = 0x03D8,

        [Description("Button 985")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_985 = 0x03D9,

        [Description("Button 986")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_986 = 0x03DA,

        [Description("Button 987")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_987 = 0x03DB,

        [Description("Button 988")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_988 = 0x03DC,

        [Description("Button 989")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_989 = 0x03DD,

        [Description("Button 990")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_990 = 0x03DE,

        [Description("Button 991")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_991 = 0x03DF,

        [Description("Button 992")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_992 = 0x03E0,

        [Description("Button 993")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_993 = 0x03E1,

        [Description("Button 994")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_994 = 0x03E2,

        [Description("Button 995")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_995 = 0x03E3,

        [Description("Button 996")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_996 = 0x03E4,

        [Description("Button 997")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_997 = 0x03E5,

        [Description("Button 998")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_998 = 0x03E6,

        [Description("Button 999")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_999 = 0x03E7,

        [Description("Button 1000")]
        [UsageType("Sel" + UsageTypeAttribute.Separator + "OOC" + UsageTypeAttribute.Separator + "MC" + UsageTypeAttribute.Separator + "OSC")]
        Button_1000 = 0x03E8,
    }
}

/*
    public static string Generate(int min, int max)
    {
        var result = string.Empty;
        var types = "\"Sel\" + UsageTypeAttribute.Separator + \"OOC\" + UsageTypeAttribute.Separator + \"MC\" + UsageTypeAttribute.Separator + \"OSC\"";
        for (var i = min; i < max + 1; i++)
        {
            result += 
                $"[Description(\"Button {i}\")]\n" +
                $"[UsageType({types})]\n" +
                $"Button_{i} = 0x{i:X4},\n"+
                $"\n";
        }

        return result;
    }
 */
