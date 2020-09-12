using System;

namespace HID_Report_Descriptor_Editor.Attributes
{
    public class UsageTypeAttribute : Attribute
    {
        public string Attribute { get; }
        public const string Separator = ",";

        public UsageTypeAttribute(string type)
        {
            Attribute = type;
        }
    }
}
