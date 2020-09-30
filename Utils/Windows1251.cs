using System.Text;

namespace HID_Report_Descriptor_Editor.Utils
{
    public class Windows1251 : Encoding
    {
        static string alpha =
            "................................" +
            " !\"#$%&'()*+,-./0123456789:;<=>?" +
            "@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_" +
            "`abcdefghijklmnopqrstuvwxyz{|}~." +
            "ЂЃ‚ѓ„…†‡€‰Љ‹ЊЌЋЏђ‘’“”•–—.™љ›њќћџ" +
            ".ЎўЈ¤Ґ¦§Ё©Є«¬.®Ї°±Ііґµ¶·ё№є»јЅѕї" +
            "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "абвгдежзийклмнопрстуфхцчшщъыьэюя";

        public override int GetByteCount(char[] chars, int index, int count)
        {
            return count;
        }

        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            byte questionIndex = (byte)alpha.IndexOf('?');
            for (int i = 0; i < charCount; i++)
            {
                int toIndex = byteIndex + i;
                int index = alpha.IndexOf(chars[charIndex + i]);
                if (index == -1)
                    bytes[toIndex] = questionIndex;
                else
                    bytes[toIndex] = (byte)index;
            }
            return charCount;
        }

        public override int GetCharCount(byte[] bytes, int index, int count)
        {
            return count;
        }

        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
            for (int i = 0; i < byteCount; i++)
            {
                var inChar = bytes[byteIndex + i];
                var outChar = alpha[inChar];
                chars[i + charIndex] = outChar;
            }
            return byteCount;
        }

        public override int GetMaxByteCount(int charCount)
        {
            return charCount;
        }

        public override int GetMaxCharCount(int byteCount)
        {
            return byteCount;
        }

    }
}