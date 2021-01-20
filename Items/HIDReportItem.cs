using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Enums;
using HID_Report_Descriptor_Editor.Utils;
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HID_Report_Descriptor_Editor.Items
{
    [XmlInclude(typeof(ShortItem))]
    [XmlInclude(typeof(LongItem))]
    public abstract class HIDReportItem
    {
        protected const int OffsetWidth = 4;

        /// <summary>
        /// Определяет принадлежность элемента.
        /// </summary>
        [XmlIgnore]
        public HIDReportHeader Header { get; set; }

        /// <summary>
        /// Данные элемента. Максимум 4 байта.
        /// </summary>
        [XmlIgnore]
        public object Value { get; set; }

        /// <summary>
        /// Строка байт.
        /// </summary>
        [XmlAttribute("Bytes")]
        public string BytesString
        {
            get
            {
                var bytes = GetBytes();
                return BitConverter.ToString(bytes).Replace('-', ' ');
            }
            set
            {
                var bytes = value.Split(' ')
                    .Select(hex => Convert.ToByte(hex, 16))
                    .ToArray();

                Header = HIDReportHeader.FromByte(bytes.First());

                Value = ParseBytes(bytes.Skip(1).ToArray());
            }
        }

        /// <summary>
        /// Комментарий.
        /// </summary>
        [XmlAttribute("Comment")]
        public string Comment { get; set; }


        public virtual string ToString(HIDReportItemCollection reportItems, out int openCollectionCount)
        {
            var index = reportItems.IndexOf(this);
            openCollectionCount = reportItems.GetOpenCollectionCount(index);

            var _value = $"0x{Value:X}";

            switch (Header.Type)
            {
                case ItemType.Main:
                    switch ((ItemTagMain)Header.Tag)
                    {
                        case ItemTagMain.Input:
                            var bits1 = GetMainDescription((uint)Value).ToList();
                            bits1.RemoveAt(7);
                            _value = bits1.Aggregate((c, n) => $"{c},{n}");
                            break;
                        case ItemTagMain.Output:
                        case ItemTagMain.Feature:
                            var bits2 = GetMainDescription((uint)Value);
                            _value = bits2.Aggregate((c, n) => $"{c},{n}");
                            break;
                        case ItemTagMain.Collection:
                            var typedValue = Enum.ToObject(typeof(CollectionType), Value);
                            _value = EnumHelper.GetEnumDescription(typedValue);
                            break;
                        case ItemTagMain.EndCollection:
                            openCollectionCount--;
                            break;
                    }
                    break;

                case ItemType.Global:
                    switch ((ItemTagGlobal)Header.Tag)
                    {
                        case ItemTagGlobal.UsagePage:
                            var typedValue = Enum.ToObject(typeof(UsagePage), Value);
                            _value = EnumHelper.GetEnumDescription(typedValue);
                            break;
                        case ItemTagGlobal.LogicalMinimum:
                        case ItemTagGlobal.LogicalMaximum:
                        case ItemTagGlobal.PhysicalMinimum:
                        case ItemTagGlobal.PhysicalMaximum:
                            _value = $"{Value:#;-#;0}";
                            break;
                        case ItemTagGlobal.UnitExponent:
                            break;
                        case ItemTagGlobal.Unit:
                            break;
                        case ItemTagGlobal.ReportSize:
                        case ItemTagGlobal.ReportID:
                        case ItemTagGlobal.ReportCount:
                            _value = Value.ToString();
                            break;
                    }
                    break;

                case ItemType.Local:
                    switch ((ItemTagLocal)Header.Tag)
                    {
                        case ItemTagLocal.Usage:
                        case ItemTagLocal.UsageMinimum:
                        case ItemTagLocal.UsageMaximum:
                            var topUsagePage = reportItems.GetTopUsagePage(index);
                            if (topUsagePage.HasValue)
                            {
                                var usageType = topUsagePage.GetAttributeOfType<UsagePageAttribute>()?.UsageType;
                                if (usageType != null)
                                {
                                    var val = Enum.ToObject(usageType, Value);
                                    _value = EnumHelper.GetEnumDescription(val);
                                    break;
                                }
                            }
                            _value = $"0x{Convert.ToInt32(Value):X4}";
                            break;
                        case ItemTagLocal.DesignatorIndex:
                            break;
                        case ItemTagLocal.DesignatorMinimum:
                            break;
                        case ItemTagLocal.DesignatorMaximum:
                            break;
                        case ItemTagLocal.StringIndex:
                            break;
                        case ItemTagLocal.StringMinimum:
                            break;
                        case ItemTagLocal.StringMaximum:
                            break;
                        case ItemTagLocal.Delimiter:
                            break;
                        default:
                            break;
                    }
                    break;

                case ItemType.LongItem:
                    _value = $"0x{{0:X2}}";
                    break;
            }

            var result = GetOffset(OffsetWidth * openCollectionCount) + Header;

            if (Value != null)
            {
                result += $" ({_value})";
            }

            return result;
        }

        public override string ToString()
        {
            return Header + " (" + Value?.ToString() + ")";
        }

        private string GetOffset(int width)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < width; i++)
            {
                builder.Append(' ');
            }
            return builder.ToString();
        }

        private static string[] GetMainDescription(uint value)
        {
            return new string[]
            {
                BitOperations.IsSetBit(value, 0) ? "Const" : "Data",
                BitOperations.IsSetBit(value, 1) ? "Var" : "Array",
                BitOperations.IsSetBit(value, 2) ? "Rel" : "Abs",
                BitOperations.IsSetBit(value, 3) ? "Wrap" : "NoWrap",
                BitOperations.IsSetBit(value, 4) ? "NoLinear" : "Linear",
                BitOperations.IsSetBit(value, 5) ? "NoPref" : "Pref",
                BitOperations.IsSetBit(value, 6) ? "Null" : "NotNull",
                BitOperations.IsSetBit(value, 7) ? "Valatile" : "NotValatile",
                BitOperations.IsSetBit(value, 8) ? "Buff" : "BitField",
            };
        }

        public virtual byte[] GetBytes()
        {
            throw new NotSupportedException();
        }

        public virtual object ParseBytes(byte[] bytes)
        {
            throw new NotSupportedException();
        }
    }
}