using System;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            r = (r / 100) * 3.5;
            d = d * 1.5;
            e = e * 1.95;
            b = b / 2;      

            double lowestPrice = double.MaxValue;
            lowestPrice = Math.Min(r, lowestPrice);
            lowestPrice = Math.Min(d, lowestPrice);
            lowestPrice = Math.Min(e, lowestPrice);
            lowestPrice = Math.Min(b, lowestPrice);
            lowestPrice = Math.Min(m, lowestPrice);

            Console.WriteLine("{0:F}",lowestPrice);

        }
    }
}
