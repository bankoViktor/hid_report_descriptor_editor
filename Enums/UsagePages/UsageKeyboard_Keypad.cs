using HID_Report_Descriptor_Editor.Attributes;
using System.ComponentModel;

namespace HID_Report_Descriptor_Editor.Enums.UsagePages
{
    public enum UsageKeyboard_Keypad : ushort
    {
        // ширина 2 байта
        [Description("Undefined")]
        Undefined = 0x0000,

        [Description("Keyboard ErrorRollOver")]
        [UsageType("Sel")]
        Keyboard_ErrorRollOver = 0x0001,

        [Description("Keyboard POSTFail")]
        [UsageType("Sel")]
        Keyboard_POSTFail = 0x0002,

        [Description("Keyboard ErrorUndefined")]
        [UsageType("Sel")]
        Keyboard_ErrorUndefined = 0x0003,

        [Description("Keyboard a and A")]
        [UsageType("Sel")]
        Keyboard_a_A = 0x0004,

        [Description("Keyboard b and B")]
        [UsageType("Sel")]
        Keyboard_b_B = 0x0005,

        [Description("Keyboard c and C")]
        [UsageType("Sel")]
        Keyboard_c_C = 0x0006,

        [Description("Keyboard d and D")]
        [UsageType("Sel")]
        Keyboard_d_D = 0x0007,

        [Description("Keyboard e and E")]
        [UsageType("Sel")]
        Keyboard_e_E = 0x0008,

        [Description("Keyboard f and F")]
        [UsageType("Sel")]
        Keyboard_f_F = 0x0009,

        [Description("Keyboard g and G")]
        [UsageType("Sel")]
        Keyboard_g_G = 0x000A,

        [Description("Keyboard h and H")]
        [UsageType("Sel")]
        Keyboard_h_H = 0x000B,

        [Description("Keyboard i and I")]
        [UsageType("Sel")]
        Keyboard_i_I = 0x000C,

        [Description("Keyboard j and J")]
        [UsageType("Sel")]
        Keyboard_j_J = 0x000D,

        [Description("Keyboard k and K")]
        [UsageType("Sel")]
        Keyboard_k_K = 0x000E,

        [Description("Keyboard l and L")]
        [UsageType("Sel")]
        Keyboard_l_L = 0x000F,

        [Description("Keyboard m and M")]
        [UsageType("Sel")]
        Keyboard_m_M = 0x0010,

        [Description("Keyboard n and N")]
        [UsageType("Sel")]
        Keyboard_n_N = 0x0011,

        [Description("Keyboard o and O")]
        [UsageType("Sel")]
        Keyboard_o_O = 0x0012,

        [Description("Keyboard p and P")]
        [UsageType("Sel")]
        Keyboard_p_P = 0x0013,

        [Description("Keyboard q and Q")]
        [UsageType("Sel")]
        Keyboard_q_Q = 0x0014,

        [Description("Keyboard r and R")]
        [UsageType("Sel")]
        Keyboard_r_R = 0x0015,

        [Description("Keyboard s and S")]
        [UsageType("Sel")]
        Keyboard_s_S = 0x0016,

        [Description("Keyboard t and T")]
        [UsageType("Sel")]
        Keyboard_t_T = 0x0017,

        [Description("Keyboard u and U")]
        [UsageType("Sel")]
        Keyboard_u_U = 0x0018,

        [Description("Keyboard v and V")]
        [UsageType("Sel")]
        Keyboard_v_V = 0x0019,

        [Description("Keyboard w and W")]
        [UsageType("Sel")]
        Keyboard_w_W = 0x001A,

        [Description("Keyboard x and X")]
        [UsageType("Sel")]
        Keyboard_x_X = 0x001B,

        [Description("Keyboard y and Y")]
        [UsageType("Sel")]
        Keyboard_y_Y = 0x001C,

        [Description("Keyboard z and Z")]
        [UsageType("Sel")]
        Keyboard_z_Z = 0x001D,

        [Description("Keyboard 1 and !")]
        [UsageType("Sel")]
        Keyboard_1_ExclamationMark = 0x001E,

        [Description("Keyboard 2 and @")]
        [UsageType("Sel")]
        Keyboard_2_At = 0x001F,

        [Description("Keyboard 3 and #")]
        [UsageType("Sel")]
        Keyboard_3_Hash = 0x0020,

        [Description("Keyboard 4 and $")]
        [UsageType("Sel")]
        Keyboard_4_Dollar = 0x0021,

        [Description("Keyboard 5 and %")]
        [UsageType("Sel")]
        Keyboard_5_Percent = 0x0022,

        [Description("Keyboard 6 and ^")]
        [UsageType("Sel")]
        Keyboard_6_Caret = 0x0023,

        [Description("Keyboard 7 and &")]
        [UsageType("Sel")]
        Keyboard_7_Ampersand = 0x0024,

        [Description("Keyboard 8 and *")]
        [UsageType("Sel")]
        Keyboard_8_Asterisk = 0x0025,

        [Description("Keyboard 9 and (")]
        [UsageType("Sel")]
        Keyboard_9_LeftParenthesis = 0x0026,

        [Description("Keyboard 0 and )")]
        [UsageType("Sel")]
        Keyboard_0_RightParenthesis = 0x0027,

        [Description("Keyboard Return (ENTER)")]
        [UsageType("Sel")]
        Keyboard_Return_ENTER = 0x0028,

        [Description("Keyboard ESCAPE")]
        [UsageType("Sel")]
        Keyboard_ESCAPE = 0x0029,

        [Description("Keyboard DELETE (Backspace)")]
        [UsageType("Sel")]
        Keyboard_DELETE_Backspace = 0x002A,

        [Description("Keyboard Tab")]
        [UsageType("Sel")]
        Keyboard_Tab = 0x002B,

        [Description("Keyboard Spacebar")]
        [UsageType("Sel")]
        Keyboard_Spacebar = 0x002C,

        [Description("Keyboard - and _(underscore)")]
        [UsageType("Sel")]
        Keyboard_Hyphen_Underscore = 0x002D,

        [Description("Keyboard = and +")]
        [UsageType("Sel")]
        Keyboard_Equal_Plus = 0x002E,

        [Description("Keyboard [ and {")]
        [UsageType("Sel")]
        Keyboard_LeftSquareBracket_LeftBrace = 0x002F,

        [Description("Keyboard ] and }")]
        [UsageType("Sel")]
        Keyboard_RightSquareBracket_RightBrace = 0x0030,

        [Description("Keyboard \\ and |")]
        [UsageType("Sel")]
        Keyboard_BackSlash_VerticalLine = 0x0031,

        [Description("Keyboard Non-US # and ~")]
        [UsageType("Sel")]
        Keyboard_NonUSHash_Tilde = 0x0032,

        [Description("Keyboard ; and :")]
        [UsageType("Sel")]
        Keyboard_Semicolon_Colon = 0x0033,

        [Description("Keyboard ' and \"")]
        [UsageType("Sel")]
        Keyboard_Quote_DoubleQuote = 0x0034,

        [Description("Keyboard Grave Accent and ~")]
        [UsageType("Sel")]
        Keyboard_GraveAccent_Tilde = 0x0035,

        [Description("Keyboard , and <")]
        [UsageType("Sel")]
        Keyboard_Comma_LeftAngleBracket = 0x0036,

        [Description("Keyboard . and >")]
        [UsageType("Sel")]
        Keyboard_Dot_RightAngleBracket = 0x0037,

        [Description("Keyboard / and ?")]
        [UsageType("Sel")]
        Keyboard_Slash_QuestionMark = 0x0038,

        [Description("Keyboard Caps Lock")]
        [UsageType("Sel")]
        Keyboard_CapsLock = 0x0039,

        [Description("Keyboard F1")]
        [UsageType("Sel")]
        Keyboard_F1 = 0x003A,

        [Description("Keyboard F2")]
        [UsageType("Sel")]
        Keyboard_F2 = 0x003B,

        [Description("Keyboard F3")]
        [UsageType("Sel")]
        Keyboard_F3 = 0x003C,

        [Description("Keyboard F4")]
        [UsageType("Sel")]
        Keyboard_F4 = 0x003D,

        [Description("Keyboard F5")]
        [UsageType("Sel")]
        Keyboard_F5 = 0x003E,

        [Description("Keyboard F6")]
        [UsageType("Sel")]
        Keyboard_F6 = 0x003F,

        [Description("Keyboard F7")]
        [UsageType("Sel")]
        Keyboard_F7 = 0x0040,

        [Description("Keyboard F8")]
        [UsageType("Sel")]
        Keyboard_F8 = 0x0041,

        [Description("Keyboard F9")]
        [UsageType("Sel")]
        Keyboard_F9 = 0x0042,

        [Description("Keyboard F10")]
        [UsageType("Sel")]
        Keyboard_F10 = 0x0043,

        [Description("Keyboard F11")]
        [UsageType("Sel")]
        Keyboard_F11 = 0x0044,

        [Description("Keyboard F12")]
        [UsageType("Sel")]
        Keyboard_F12 = 0x0045,

        [Description("Keyboard PrintScreen")]
        [UsageType("Sel")]
        Keyboard_PrintScreen = 0x0046,

        [Description("Keyboard Scroll Lock")]
        [UsageType("Sel")]
        Keyboard_ScrollLock = 0x0047,

        [Description("Keyboard Pause")]
        [UsageType("Sel")]
        Keyboard_Pause = 0x0048,

        [Description("Keyboard Insert")]
        [UsageType("Sel")]
        Keyboard_Insert = 0x0049,

        [Description("Keyboard Home")]
        [UsageType("Sel")]
        Keyboard_Home = 0x004A,

        [Description("Keyboard PageUp")]
        [UsageType("Sel")]
        Keyboard_PageUp = 0x004B,

        [Description("Keyboard Delete Forward")]
        [UsageType("Sel")]
        Keyboard_DeleteForward = 0x004C,

        [Description("Keyboard End")]
        [UsageType("Sel")]
        Keyboard_End = 0x004D,

        [Description("Keyboard PageDown")]
        [UsageType("Sel")]
        Keyboard_PageDown = 0x004E,

        [Description("Keyboard RightArrow")]
        [UsageType("Sel")]
        Keyboard_RightArrow = 0x004F,

        [Description("Keyboard RightArrow")]
        [UsageType("Sel")]
        Keyboard_LeftArrow = 0x0050,

        [Description("Keyboard DownArrow")]
        [UsageType("Sel")]
        Keyboard_DownArrow = 0x0051,

        [Description("Keyboard UpArrow")]
        [UsageType("Sel")]
        Keyboard_UpArrow = 0x0052,

        [Description("Keypad Num Lock and Clear")]
        [UsageType("Sel")]
        Keypad_NumLock_Clear = 0x0053,

        [Description("Keypad /")]
        [UsageType("Sel")]
        Keypad_Slash = 0x0054,

        [Description("Keypad *")]
        [UsageType("Sel")]
        Keypad_Asterisk = 0x0055,

        [Description("Keypad -")]
        [UsageType("Sel")]
        Keypad_Minus = 0x0056,

        [Description("Keypad +")]
        [UsageType("Sel")]
        Keypad_Plus = 0x0057,

        [Description("Keypad ENTER")]
        [UsageType("Sel")]
        Keypad_ENTER = 0x0058,

        [Description("Keypad 1 and End")]
        [UsageType("Sel")]
        Keypad_1_End = 0x0059,

        [Description("Keypad 2 and Down Arrow")]
        [UsageType("Sel")]
        Keypad_2_DownArrow = 0x005A,

        [Description("Keypad 3 and Page Down")]
        [UsageType("Sel")]
        Keypad_3_PageDown = 0x005B,

        [Description("Keypad 4 and Left Arrow")]
        [UsageType("Sel")]
        Keypad_4_LeftArrow = 0x005C,

        [Description("Keypad 5")]
        [UsageType("Sel")]
        Keypad_5 = 0x005D,

        [Description("Keypad 6 and Right Arrow")]
        [UsageType("Sel")]
        Keypad_6_RightArrow = 0x005E,

        [Description("Keypad 7 and Home")]
        [UsageType("Sel")]
        Keypad_7_Home = 0x005F,

        [Description("Keypad 8 and Up Arrow")]
        [UsageType("Sel")]
        Keypad_8_UpArrow = 0x0060,

        [Description("Keypad 9 and Page Up")]
        [UsageType("Sel")]
        Keypad_9_PageUp = 0x0061,

        [Description("Keypad 0 and Insert")]
        [UsageType("Sel")]
        Keypad_0_Insert = 0x0062,

        [Description("Keypad . and Delete")]
        [UsageType("Sel")]
        Keypad_Dot_Delete = 0x0063,

        [Description("Keyboard Non-US \\ and |")]
        [UsageType("Sel")]
        Keyboard_NonUSBackSlash_VerticalLine = 0x0064,

        [Description("Keyboard Application")]
        [UsageType("Sel")]
        Keyboard_Application = 0x0065,

        [Description("Keyboard Power")]
        [UsageType("Sel")]
        Keyboard_Power = 0x0066,

        [Description("Keypad =")]
        [UsageType("Sel")]
        Keypad_Equals = 0x0067,

        [Description("Keyboard F13")]
        [UsageType("Sel")]
        Keyboard_F13 = 0x0068,

        [Description("Keyboard F14")]
        [UsageType("Sel")]
        Keyboard_F14 = 0x0069,

        [Description("Keyboard F15")]
        [UsageType("Sel")]
        Keyboard_F15 = 0x006A,

        [Description("Keyboard F16")]
        [UsageType("Sel")]
        Keyboard_F16 = 0x006B,

        [Description("Keyboard F17")]
        [UsageType("Sel")]
        Keyboard_F17 = 0x006C,

        [Description("Keyboard F18")]
        [UsageType("Sel")]
        Keyboard_F18 = 0x006D,

        [Description("Keyboard F19")]
        [UsageType("Sel")]
        Keyboard_F19 = 0x006E,

        [Description("Keyboard F20")]
        [UsageType("Sel")]
        Keyboard_F20 = 0x006F,

        [Description("Keyboard F21")]
        [UsageType("Sel")]
        Keyboard_F21 = 0x0070,

        [Description("Keyboard F22")]
        [UsageType("Sel")]
        Keyboard_F22 = 0x0071,

        [Description("Keyboard F23")]
        [UsageType("Sel")]
        Keyboard_F23 = 0x0072,

        [Description("Keyboard F24")]
        [UsageType("Sel")]
        Keyboard_F24 = 0x0073,

        [Description("Keyboard Execute")]
        [UsageType("Sel")]
        Keyboard_Execute = 0x0074,

        [Description("Keyboard Help")]
        [UsageType("Sel")]
        Keyboard_Help = 0x0075,

        [Description("Keyboard Menu")]
        [UsageType("Sel")]
        Keyboard_Menu = 0x0076,

        [Description("Keyboard Select")]
        [UsageType("Sel")]
        Keyboard_Select = 0x0077,

        [Description("Keyboard Stop")]
        [UsageType("Sel")]
        Keyboard_Stop = 0x0078,

        [Description("Keyboard Again")]
        [UsageType("Sel")]
        Keyboard_Again = 0x0079,

        [Description("Keyboard Undo")]
        [UsageType("Sel")]
        Keyboard_Undo = 0x007A,

        [Description("Keyboard Cut")]
        [UsageType("Sel")]
        Keyboard_Cut = 0x007B,

        [Description("Keyboard Copy")]
        [UsageType("Sel")]
        Keyboard_Copy = 0x007C,

        [Description("Keyboard Paste")]
        [UsageType("Sel")]
        Keyboard_Paste = 0x007D,

        [Description("Keyboard Find")]
        [UsageType("Sel")]
        Keyboard_Find = 0x007E,

        [Description("Keyboard Mute")]
        [UsageType("Sel")]
        Keyboard_Mute = 0x007F,

        [Description("Keyboard Volume Up")]
        [UsageType("Sel")]
        Keyboard_VolumeUp = 0x0080,

        [Description("Keyboard Volume Down")]
        [UsageType("Sel")]
        Keyboard_VolumeDown = 0x0081,

        [Description("Keyboard Locking Caps Lock")]
        [UsageType("Sel")]
        Keyboard_LockingCapsLock = 0x0082,

        [Description("Keyboard Locking Num Lock")]
        [UsageType("Sel")]
        Keyboard_LockingNumLock = 0x0083,

        [Description("Keyboard Locking Scroll Lock")]
        [UsageType("Sel")]
        Keyboard_LockingScrollLock = 0x0084,

        [Description("Keypad Comma")]
        [UsageType("Sel")]
        Keypad_Comma = 0x0085,

        [Description("Keypad Equal Sign")]
        [UsageType("Sel")]
        Keypad_EqualSign = 0x0086,

        [Description("Keyboard International 1")]
        [UsageType("Sel")]
        Keyboard_International_1 = 0x0087,

        [Description("Keyboard International 2")]
        [UsageType("Sel")]
        Keyboard_International_2 = 0x0088,

        [Description("Keyboard International 3")]
        [UsageType("Sel")]
        Keyboard_International_3 = 0x0089,

        [Description("Keyboard International 4")]
        [UsageType("Sel")]
        Keyboard_International_4 = 0x008A,

        [Description("Keyboard International 5")]
        [UsageType("Sel")]
        Keyboard_International_5 = 0x008B,

        [Description("Keyboard International 6")]
        [UsageType("Sel")]
        Keyboard_International_6 = 0x008C,

        [Description("Keyboard International 7")]
        [UsageType("Sel")]
        Keyboard_International_7 = 0x008D,

        [Description("Keyboard International 8")]
        [UsageType("Sel")]
        Keyboard_International_8 = 0x008E,

        [Description("Keyboard International 9")]
        [UsageType("Sel")]
        Keyboard_International_9 = 0x008F,

        [Description("Keyboard LANG 1")]
        [UsageType("Sel")]
        Keyboard_LANG_1 = 0x0090,

        [Description("Keyboard LANG 2")]
        [UsageType("Sel")]
        Keyboard_LANG_2 = 0x0091,

        [Description("Keyboard LANG 3")]
        [UsageType("Sel")]
        Keyboard_LANG_3 = 0x0092,

        [Description("Keyboard LANG 4")]
        [UsageType("Sel")]
        Keyboard_LANG_4 = 0x0093,

        [Description("Keyboard LANG 5")]
        [UsageType("Sel")]
        Keyboard_LANG_5 = 0x0094,

        [Description("Keyboard LANG 6")]
        [UsageType("Sel")]
        Keyboard_LANG_6 = 0x0095,

        [Description("Keyboard LANG 7")]
        [UsageType("Sel")]
        Keyboard_LANG_7 = 0x0096,

        [Description("Keyboard LANG 8")]
        [UsageType("Sel")]
        Keyboard_LANG_8 = 0x0097,

        [Description("Keyboard LANG 9")]
        [UsageType("Sel")]
        Keyboard_LANG_9 = 0x0098,

        [Description("Keyboard Alternate Erase")]
        [UsageType("Sel")]
        Keyboard_AlternateErase = 0x0099,

        [Description("Keyboard SysReq/Attention")]
        [UsageType("Sel")]
        Keyboard_SysReq_Attention = 0x009A,

        [Description("Keyboard Cancel")]
        [UsageType("Sel")]
        Keyboard_Cancel = 0x009B,

        [Description("Keyboard Clear")]
        [UsageType("Sel")]
        Keyboard_Clear = 0x009C,

        [Description("Keyboard Prior")]
        [UsageType("Sel")]
        Keyboard_Prior = 0x009D,

        [Description("Keyboard Return")]
        [UsageType("Sel")]
        Keyboard_Return = 0x009E,

        [Description("Keyboard Separator")]
        [UsageType("Sel")]
        Keyboard_Separator = 0x009F,

        [Description("Keyboard Out")]
        [UsageType("Sel")]
        Keyboard_Out = 0x00A0,

        [Description("Keyboard Oper")]
        [UsageType("Sel")]
        Keyboard_Oper = 0x00A1,

        [Description("Keyboard Clear/Again")]
        [UsageType("Sel")]
        Keyboard_Clear_Again = 0x00A2,

        [Description("Keyboard CrSel/Props")]
        [UsageType("Sel")]
        Keyboard_CrSel_Props = 0x00A3,

        [Description("Keyboard ExSel")]
        [UsageType("Sel")]
        Keyboard_ExSel = 0x00A4,

        // reserved 0x00A5 - 0x00AF

        [Description("Keypad 00")]
        [UsageType("Sel")]
        Keypad_00 = 0x00B0,

        [Description("Keypad 000")]
        [UsageType("Sel")]
        Keypad_000 = 0x00B1,

        [Description("Thousands Separator")]
        [UsageType("Sel")]
        ThousandsSeparator = 0x00B2,

        [Description("Decimal Separator")]
        [UsageType("Sel")]
        DecimalSeparator = 0x00B3,

        [Description("Currency Unit")]
        [UsageType("Sel")]
        CurrencyUnit = 0x00B4,

        [Description("Currency Sub-unit")]
        [UsageType("Sel")]
        CurrencySubunit = 0x00B5,

        [Description("Keypad (")]
        [UsageType("Sel")]
        Keypad_LeftParenthesis = 0x00B6,

        [Description("Keypad )")]
        [UsageType("Sel")]
        Keypad_RightParenthesis = 0x00B7,

        [Description("Keypad {")]
        [UsageType("Sel")]
        Keypad_LeftBrace = 0x00B8,

        [Description("Keypad }")]
        [UsageType("Sel")]
        Keypad_RightBrace = 0x00B9,

        [Description("Keypad Tab")]
        [UsageType("Sel")]
        Keypad_Tab = 0x00BA,

        [Description("Keypad Backspace")]
        [UsageType("Sel")]
        Keypad_Backspace = 0x00BB,

        [Description("Keypad A")]
        [UsageType("Sel")]
        Keypad_A = 0x00BC,

        [Description("Keypad B")]
        [UsageType("Sel")]
        Keypad_B = 0x00BD,

        [Description("Keypad C")]
        [UsageType("Sel")]
        Keypad_C = 0x00BE,

        [Description("Keypad D")]
        [UsageType("Sel")]
        Keypad_D = 0x00BF,

        [Description("Keypad E")]
        [UsageType("Sel")]
        Keypad_E = 0x00C0,

        [Description("Keypad F")]
        [UsageType("Sel")]
        Keypad_F = 0x00C1,

        [Description("Keypad XOR")]
        [UsageType("Sel")]
        Keypad_XOR = 0x00C2,

        [Description("Keypad ^")]
        [UsageType("Sel")]
        Keypad_Caret = 0x00C3,

        [Description("Keypad %")]
        [UsageType("Sel")]
        Keypad_Percent = 0x00C4,

        [Description("Keypad <")]
        [UsageType("Sel")]
        Keypad_LeftAngleBracket = 0x00C5,

        [Description("Keypad >")]
        [UsageType("Sel")]
        Keypad_RightAngleBracket = 0x00C6,

        [Description("Keypad &")]
        [UsageType("Sel")]
        Keypad_Ampersand = 0x00C7,

        [Description("Keypad &&")]
        [UsageType("Sel")]
        Keypad_DoubleAmpersand = 0x00C8,

        [Description("Keypad |")]
        [UsageType("Sel")]
        Keypad_VerticalLine = 0x00C9,

        [Description("Keypad ||")]
        [UsageType("Sel")]
        Keypad_DoubleVerticalLine = 0x00CA,

        [Description("Keypad :")]
        [UsageType("Sel")]
        Keypad_Colon = 0x00CB,

        [Description("Keypad #")]
        [UsageType("Sel")]
        Keypad_Hash = 0x00CC,

        [Description("Keypad Space")]
        [UsageType("Sel")]
        Keypad_Space = 0x00CD,

        [Description("Keypad @")]
        [UsageType("Sel")]
        Keypad_At = 0x00CE,

        [Description("Keypad !")]
        [UsageType("Sel")]
        Keypad_ExclamationMark = 0x00CF,

        [Description("Keypad Memory Store")]
        [UsageType("Sel")]
        Keypad_MemoryStore = 0x00D0,

        [Description("Keypad Memory Recall")]
        [UsageType("Sel")]
        Keypad_MemoryRecall = 0x00D1,

        [Description("Keypad Memory Clear")]
        [UsageType("Sel")]
        Keypad_MemoryClear = 0x00D2,

        [Description("Keypad Memory Add")]
        [UsageType("Sel")]
        Keypad_MemoryAdd = 0x00D3,

        [Description("Keypad Memory Substract")]
        [UsageType("Sel")]
        Keypad_MemorySubstract = 0x00D4,

        [Description("Keypad Memory Multiply")]
        [UsageType("Sel")]
        Keypad_MemoryMultiply = 0x00D5,

        [Description("Keypad Memory Divide")]
        [UsageType("Sel")]
        Keypad_MemoryDivide = 0x00D6,

        [Description("Keypad Memory +/-")]
        [UsageType("Sel")]
        Keypad_PlusMinus = 0x00D7,

        [Description("Keypad Clear")]
        [UsageType("Sel")]
        Keypad_Clear = 0x00D8,

        [Description("Keypad Clear Entry")]
        [UsageType("Sel")]
        Keypad_ClearEntry = 0x00D9,

        [Description("Keypad Binary")]
        [UsageType("Sel")]
        Keypad_Binary = 0x00DA,

        [Description("Keypad Octal")]
        [UsageType("Sel")]
        Keypad_Octal = 0x00DB,

        [Description("Keypad Decimal")]
        [UsageType("Sel")]
        Keypad_Decimal = 0x00DC,

        [Description("Keypad Hexadecimal")]
        [UsageType("Sel")]
        Keypad_Hexadecimal = 0x00DD,

        // reserved 0x00DE - 0x00DF

        [Description("Keyboard LeftControl")]
        [UsageType("DF")]
        Keyboard_LeftControl = 0x00E0,

        [Description("Keyboard LeftShift")]
        [UsageType("DF")]
        Keyboard_LeftShift = 0x00E1,

        [Description("Keyboard LeftAlt")]
        [UsageType("DF")]
        Keyboard_LeftAlt = 0x00E2,

        [Description("Keyboard Left GUI")]
        [UsageType("DF")]
        Keyboard_LeftGUI = 0x00E3,

        [Description("Keyboard RightControl")]
        [UsageType("DF")]
        Keyboard_RightControl = 0x00E4,

        [Description("Keyboard RightShift")]
        [UsageType("DF")]
        Keyboard_RightShift = 0x00E5,

        [Description("Keyboard RightAlt")]
        [UsageType("DF")]
        Keyboard_RightAlt = 0x00E6,

        [Description("Keyboard Right GUI")]
        [UsageType("DF")]
        Keyboard_RightGUI = 0x00E7,

        // reserved 0x00E8 - 0xFFFF
    }
}
