using System;

namespace HID_Report_Descriptor_Editor.Attributes
{
    public class UsagePageAttribute : Attribute
    {
        public Type UsageType { get; }

        public UsagePageAttribute(Type usageType)
        {
            UsageType = usageType;
        }
    }
}
