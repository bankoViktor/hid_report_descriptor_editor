
namespace HID_Report_Descriptor_Editor.Utils
{
    public static class BitOperations
    {
        public static bool IsSetBit(int value, int bit)
        {
            return (value & (1 << bit)) > 0;
        }

        public static bool IsSetBit(uint value, int bit)
        {
            return (value & (1 << bit)) > 0;
        }
    }
}
