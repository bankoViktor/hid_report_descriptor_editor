using HID_Report_Descriptor_Editor.Attributes;
using HID_Report_Descriptor_Editor.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace HID_Report_Descriptor_Editor.Items
{
    [DebuggerDisplay("{Name,nq} ({ValueDebug,nq})")]
    public class ShortItem
    {
        private const int OffsetWidth = 4;

        public ItemType Type { get; }
        public object Tag { get; private set; }
        public object Value { get; set; }
        public string BytesString
        {
            get
            {
                string str = string.Empty;
                foreach (var item in GetBytes())
                    str += $"{item:X2} ";
                return str[0..^1];
            }
        }
        public string Name { get => GetEnumDescription(Tag); }
        private string ValueDebug
        {
            get => Value != null ? $"0x{Convert.ChangeType(Value, typeof(short)):X}" : "NULL";
        }

        #region Constructors

        public ShortItem(ShortItem copyFrom)
        {
            Type = copyFrom.Type;
            Tag = copyFrom.Tag;
            Value = copyFrom.Value;
        }

        public ShortItem(ItemType type, object tag, object value)
        {
            Type = type;
            Value = value;

            switch (type)
            {
                case ItemType.Main:
                    Tag = (ItemTagMain)tag;
                    break;

                case ItemType.Global:
                    Tag = (ItemTagGlobal)tag;
                    break;

                case ItemType.Local:
                    Tag = (ItemTagLocal)tag;
                    break;
            }
        }

        public ShortItem(ItemTagMain mainTag)
        {
            Type = ItemType.Main;
            Tag = mainTag;
        }

        public ShortItem(ItemTagGlobal globalTag)
        {
            Type = ItemType.Global;
            Tag = globalTag;
        }

        public ShortItem(ItemTagLocal localTag)
        {
            Type = ItemType.Local;
            Tag = localTag;
        }

        #endregion

        public override string ToString()
        {
            var type = Enum.GetName(Type.GetType(), Type).First();
            return $"--[{type}]  {Name}";
        }

        public byte[] GetBytes()
        {
            byte[] valueBytes;

            if (Value == null)
            {
                valueBytes = new byte[0];
            }
            else
            {
                int intValue = (int)Value;
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

            byte bType = (byte)(int)Type;
            byte bTag = (byte)(int)Tag;
            byte bSize = (byte)GetSize(valueBytes);
            var bytes = new byte[] { (byte)(bTag << 4 | bType << 2 | bSize) };

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

        public static readonly ShortItem[] ShortItemsCollection = new ShortItem[] {
            // Main
            new ShortItem(ItemTagMain.Input),
            new ShortItem(ItemTagMain.Output),
            new ShortItem(ItemTagMain.Collection),
            new ShortItem(ItemTagMain.Feature),
            new ShortItem(ItemTagMain.EndCollection),
            // Global
            new ShortItem(ItemTagGlobal.UsagePage),
            new ShortItem(ItemTagGlobal.LogicalMinimum),
            new ShortItem(ItemTagGlobal.LogicalMaximum),
            new ShortItem(ItemTagGlobal.PhysicalMinimum),
            new ShortItem(ItemTagGlobal.PhysicalMaximum),
            new ShortItem(ItemTagGlobal.UnitExponent),
            new ShortItem(ItemTagGlobal.Unit),
            new ShortItem(ItemTagGlobal.ReportSize),
            new ShortItem(ItemTagGlobal.ReportID),
            new ShortItem(ItemTagGlobal.ReportCount),
            new ShortItem(ItemTagGlobal.Push),
            new ShortItem(ItemTagGlobal.Pop),
            // Local
            new ShortItem(ItemTagLocal.Usage),
            new ShortItem(ItemTagLocal.UsageMinimum),
            new ShortItem(ItemTagLocal.UsageMaximum),
            new ShortItem(ItemTagLocal.DesignatorIndex),
            new ShortItem(ItemTagLocal.DesignatorMinimum),
            new ShortItem(ItemTagLocal.DesignatorMaximum),
            new ShortItem(ItemTagLocal.StringIndex),
            new ShortItem(ItemTagLocal.StringMinimum),
            new ShortItem(ItemTagLocal.StringMaximum),
            new ShortItem(ItemTagLocal.Delimiter),
        };

        public static string GetEnumDescription(object enumeration)
        {
            var type = enumeration.GetType();
            if (type.IsEnum)
            {
                var name = Enum.GetName(type, enumeration);
                if (name != null)
                {
                    var fi = type.GetField(name);
                    var attr = fi.GetCustomAttribute<DescriptionAttribute>();
                    return attr != null ? attr.Description : name;
                }
                else
                    return $"0x{(int)enumeration:X}";
            }

            return enumeration.ToString();
        }

        public static Type GetUsagePageType(UsagePage usagePage)
        {
            var attr = usagePage.GetType()
                .GetField(Enum.GetName(usagePage.GetType(), usagePage))
                .GetCustomAttribute<UsagePageAttribute>();
            return attr?.UsageType;
        }

        // TODO неопределенные значчения для Enum сделать через UsagePage? var

        public static string GetDisplayText(IList<ShortItem> reportItems, int index)
        {
            UsagePage? topUsagePage = GetTopUsagePage(reportItems, index);

            var countCollection = GetTopCollection(reportItems, index);
            var item = reportItems[index];
            var _value = $"0x{item.Value:X}";

            if (item.Tag is ItemTagMain tagMain)
            {
                switch (tagMain)
                {
                    case ItemTagMain.Input:
                        break;
                    case ItemTagMain.Output:
                        break;
                    case ItemTagMain.Collection:
                        _value = GetEnumDescription((CollectionType)item.Value);
                        break;
                    case ItemTagMain.Feature:
                        break;
                    case ItemTagMain.EndCollection:
                        countCollection--;
                        break;
                }
            }
            else if (item.Tag is ItemTagGlobal tagGlobal)
            {
                switch (tagGlobal)
                {
                    case ItemTagGlobal.UsagePage:
                        _value = GetEnumDescription((UsagePage)item.Value);
                        break;
                    case ItemTagGlobal.LogicalMinimum:
                    case ItemTagGlobal.LogicalMaximum:
                    case ItemTagGlobal.PhysicalMinimum:
                    case ItemTagGlobal.PhysicalMaximum:
                        _value = $"{item.Value:#;-#;0}";
                        break;
                    case ItemTagGlobal.UnitExponent:
                        break;
                    case ItemTagGlobal.Unit:
                        break;
                    case ItemTagGlobal.ReportSize:
                    case ItemTagGlobal.ReportID:
                    case ItemTagGlobal.ReportCount:
                        _value = item.Value.ToString();
                        break;
                }
            }
            else if (item.Tag is ItemTagLocal tagLocal)
            {
                switch (tagLocal)
                {
                    case ItemTagLocal.Usage:
                    case ItemTagLocal.UsageMinimum:
                    case ItemTagLocal.UsageMaximum:
                        if (topUsagePage.HasValue)
                        {
                            var usageType = GetUsagePageType(topUsagePage.Value);
                            if (usageType != null)
                            {
                                var val = Enum.ToObject(usageType, item.Value);
                                _value = GetEnumDescription(val);
                                break;
                            }
                        }
                        _value = (int)item.Value <= 0xFF ? $"0x{(int)item.Value,2:X2}" : $"0x{(int)item.Value,4:X4}"; ;
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
            }

            var result = " ".PadLeft(OffsetWidth * countCollection) + item.Name;

            if (item.Value != null)
            {
                result += $" ({_value})";
            }

            return result;
        }

        private static int GetTopCollection(IEnumerable<ShortItem> reportItems, int currentIndex)
        {
            int result = 0;

            foreach (var item in reportItems.Reverse().Skip(reportItems.Count() - currentIndex))
            {
                if (item.Type == ItemType.Main  )
                {
                    var mainTag = (ItemTagMain)item.Tag;
                    if (mainTag == ItemTagMain.Collection)
                    {
                        result++;
                    }
                    else if (mainTag == ItemTagMain.EndCollection)
                    {
                        result--;
                    }
                }
            }

            return result;
        }

        public static UsagePage? GetTopUsagePage(IEnumerable<ShortItem> reportItems, int currentIndex)
        {
            foreach (var item in reportItems.Reverse().Skip(reportItems.Count() - currentIndex))
            {
                if (item.Type == ItemType.Global && (ItemTagGlobal)item.Tag == ItemTagGlobal.UsagePage)
                {
                    return (UsagePage)item.Value;
                }
            }

            return null;
        }
    }
}
