using System;
namespace _5.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double thirdDigit = (int)(n / (Math.Pow(10, 2))) % 10;
            Console.WriteLine("Third Digit 7? {0}", 
                thirdDigit == 7 ? true:false);
        }
    }
}
