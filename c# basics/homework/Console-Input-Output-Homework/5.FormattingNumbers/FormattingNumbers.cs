using System;

namespace _5.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            string abin = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|" 
                , a, abin, b ,c);
        }
    }
}
