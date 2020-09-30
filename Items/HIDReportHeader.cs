using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Utils;

namespace HID_Report_Descriptor_Editor.Items
{
    public struct HIDReportHeader
    {
        /// <summary>
        /// Тип элемента отчета: <i>главный</i>/<i>глобальный</i>/<i>локальный</i>.
        /// <b>Щирина</b>: 2 бита, <b>Смещение</b>: 2 бит
        /// </summary>
        public ItemType Type { get; }

        /// <summary>
        /// Тег элемента отчета, тип зависит от поля <see cref="Type"/> и 
        /// может быть: <see cref="ItemTagMain"/>, <see cref="ItemTagGlobal"/> или <see cref="ItemTagLocal"/>.
        /// <b>Щирина</b>: 2 бита, <b>Смещение</b>: 2 бит
        /// </summary>
        public byte Tag { get; set; }

        public HIDReportHeader(ItemType type, byte tag)
        {
            Type = type;
            Tag = tag;
        }

        public HIDReportHeader(ItemTagMain tagMain) : this(ItemType.Main, (byte)tagMain) { }

        public HIDReportHeader(ItemTagGlobal tagGlobal) : this(ItemType.Global, (byte)tagGlobal) { }

        public HIDReportHeader(ItemTagLocal tagLocal) : this(ItemType.Local, (byte)tagLocal) { }

        public override string ToString()
        {
            return Type switch
            {
                ItemType.Main => EnumHelper.GetEnumDescription((ItemTagMain)Tag),
                ItemType.Global => EnumHelper.GetEnumDescription((ItemTagGlobal)Tag),
                ItemType.Local => EnumHelper.GetEnumDescription((ItemTagLocal)Tag),
                ItemType.LongItem => "LONG",
                _ => $"0x{Tag:X}",
            };
        }

        public static readonly HIDReportHeader[] ShortItemHeaders =
        {
            // Main
            new HIDReportHeader(ItemTagMain.Input),
            new HIDReportHeader(ItemTagMain.Output),
            new HIDReportHeader(ItemTagMain.Collection),
            new HIDReportHeader(ItemTagMain.Feature),
            new HIDReportHeader(ItemTagMain.EndCollection),
            // Global
            new HIDReportHeader(ItemTagGlobal.UsagePage),
            new HIDReportHeader(ItemTagGlobal.LogicalMinimum),
            new HIDReportHeader(ItemTagGlobal.LogicalMaximum),
            new HIDReportHeader(ItemTagGlobal.PhysicalMinimum),
            new HIDReportHeader(ItemTagGlobal.PhysicalMaximum),
            new HIDReportHeader(ItemTagGlobal.UnitExponent),
            new HIDReportHeader(ItemTagGlobal.Unit),
            new HIDReportHeader(ItemTagGlobal.ReportSize),
            new HIDReportHeader(ItemTagGlobal.ReportID),
            new HIDReportHeader(ItemTagGlobal.ReportCount),
            new HIDReportHeader(ItemTagGlobal.Push),
            new HIDReportHeader(ItemTagGlobal.Pop),
            // Local
            new HIDReportHeader(ItemTagLocal.Usage),
            new HIDReportHeader(ItemTagLocal.UsageMinimum),
            new HIDReportHeader(ItemTagLocal.UsageMaximum),
            new HIDReportHeader(ItemTagLocal.DesignatorIndex),
            new HIDReportHeader(ItemTagLocal.DesignatorMinimum),
            new HIDReportHeader(ItemTagLocal.DesignatorMaximum),
            new HIDReportHeader(ItemTagLocal.StringIndex),
            new HIDReportHeader(ItemTagLocal.StringMinimum),
            new HIDReportHeader(ItemTagLocal.StringMaximum),
            new HIDReportHeader(ItemTagLocal.Delimiter),
        };

        public static HIDReportHeader FromByte(byte _byte_)
        {
            var type = (_byte_ & 0x0C) >> 2;
            var tag = (_byte_ & 0xF0) >> 4;
            return new HIDReportHeader((ItemType)type, (byte)tag);
        }

        public byte ToByte(ItemSize itemSize)
        {
            byte bType = (byte)(int)Type;
            byte bTag = Tag;
            byte bSize = (byte)itemSize;
            return (byte)(bTag << 4 | bType << 2 | bSize);
        }
    }
}