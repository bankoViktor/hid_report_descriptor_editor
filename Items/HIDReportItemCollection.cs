using HID_Report_Descriptor_Editor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HID_Report_Descriptor_Editor.Items
{
    public class HIDReportItemCollection : List<HIDReportItem>
    {
        public HIDReportItemCollection() { }

        public int GetOpenCollectionCount(int originIndex)
        {
            var openCount = 0;

            foreach (var item in this.Take(originIndex))
            {
                if (item.Header.Type == ItemType.Main)
                {
                    var mainTag = (ItemTagMain)item.Header.Tag;
                    if (mainTag == ItemTagMain.Collection)
                    {
                        openCount++;
                    }
                    else if (mainTag == ItemTagMain.EndCollection)
                    {
                        openCount--;
                    }
                }
            }

            if (openCount < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return openCount;
        }

        public UsagePage? GetTopUsagePage(int originIndex)
        {
            var topItems = this
                .Take(originIndex + 1)
                .Reverse();

            foreach (var item in topItems)
            {
                if (item.Header.Type == ItemType.Global &&
                    (ItemTagGlobal)item.Header.Tag == ItemTagGlobal.UsagePage)
                {
                    return (UsagePage?)Enum.ToObject(typeof(UsagePage), item.Value);
                }
            }

            return null;
        }
    }
}