using System;
using System.Numerics;

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long toDecimal = 0;

            for (int i = 0; i < number.Length; i++)
            {
                string symbol = number.Substring(i, 1);
                switch (symbol)
                {
                    case "A": toDecimal += 10 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "B": toDecimal += 11 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "C": toDecimal += 12 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "D": toDecimal += 13 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "E": toDecimal += 14 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "F": toDecimal += 15 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "1": toDecimal += 1 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "2": toDecimal += 2 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "3": toDecimal += 3 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "4": toDecimal += 4 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "5": toDecimal += 5 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "6": toDecimal += 6 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "7": toDecimal += 7 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "8": toDecimal += 8 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case "9": toDecimal += 9 * (long)Math.Pow(16, number.Length - i - 1); break;
                }
            }
            Console.WriteLine(toDecimal);
        }
    }
}
