using HID_Report_Descriptor_Editor.Enums;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace HID_Report_Descriptor_Editor.Items
{
    public class LongItem : HIDReportItem
    {
        /// <summary>
        /// Размер данных длинного элемента отчета.
        /// <b>Щирина</b>: 8 бит, <b>Смещение</b>: 8 бит 
        /// </summary>
        [XmlIgnore]
        public byte DataSize
        {
            get => Value != null && Value is byte[] bytes ? (byte)bytes.Length : 0;
        }

        /// <summary>
        /// Тег длинного элемента отчета.
        /// <b>Щирина</b>: 8 бит, <b>Смещение</b>: 16 бит 
        /// </summary>
        [XmlIgnore]
        public byte LongItemTag { get; set; }

        public LongItem()
        {
            Header = new HIDReportHeader(ItemType.LongItem, 0b1111);
        }

        public override byte[] GetBytes()
        {
           var bytes = new byte[3]
           {
                Header.ToByte(ItemSize.Word),
                DataSize,
                LongItemTag
           };

            return bytes.Concat(Value as byte[]).ToArray();
        }

        public override string ToString(HIDReportItemCollection reportItems)
        {
            var fmt = base.ToString(reportItems);
            var size = Value != null && Value is byte[] bytes ? (byte)bytes.Length : 0;
            return string.Format(fmt, LongItemTag) + $" [{size} bytes]";
        }

        public override object ParseBytes(byte[] bytes)
        {
            var bSize = bytes[0];
            LongItemTag = bytes[1];

            var valueBytes = bytes.Skip(2).ToArray();

            if (bSize != valueBytes.Length)
            {
                throw new Exception("The data size of this long item does not match the actual.");
            }

            return valueBytes;
        }
    }
}