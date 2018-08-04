using System;
using System.Text;

namespace BinToHex
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = BinaryStringToHexString(input);
            Console.WriteLine(result);
        }

        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            int modLen = binary.Length % 8;
            if (modLen != 0)
            {
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
    }
}
