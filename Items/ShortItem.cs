using HID_Report_Descriptor_Editor.Enums;
using System;
using System.Linq;

namespace HID_Report_Descriptor_Editor.Items
{
    public class ShortItem : HIDReportItem
    {
        public ShortItem() { }

        public override byte[] GetBytes()
        {
            byte[] valueBytes;

            if (Value == null)
            {
                valueBytes = new byte[0];
            }
            else
            {
                int intValue = (int)Convert.ChangeType(Value, typeof(int));
                valueBytes = BitConverter.GetBytes(intValue); // 4 байта

                if (intValue <= 0xFF)
                {
                    // 1 байт
                    valueBytes = new byte[1] { valueBytes[0] };
                }
                else if (intValue <= 0xFFFF)
                {
                    // 2 байта
                    valueBytes = new byte[2] { valueBytes[0], valueBytes[1] };
                }
            }

            var bytes = new byte[1]
            {
                Header.ToByte(GetSize(valueBytes))
            };

            return bytes.Concat(valueBytes).ToArray();
        }

        private ItemSize GetSize(byte[] bytes)
        {
            if (bytes.Length < 4)
            {
                return (ItemSize)bytes.Length;
            }
            else if (bytes.Length == 4)
            {
                return ItemSize.DWord;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public override object ParseBytes(byte[] bytes)
        {
            if (bytes.Length == 0)
            {
                return null;
            }

            var begin = 4 - bytes.Length;

            var newBytes = new byte[begin];

            var fin = bytes.Concat(newBytes).ToArray();

            return BitConverter.ToUInt32(fin, 0);
        }
    }
}