using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            double? num2 = null;
            Console.WriteLine(num1);
            Console.WriteLine(num1.HasValue);
            Console.WriteLine(num2);
            Console.WriteLine(num2.HasValue);

            num1 += 20;
            num2 += 30;
            Console.WriteLine(num1);
            Console.WriteLine(num1.HasValue);
            Console.WriteLine(num2);
            Console.WriteLine(num2.HasValue);

            num1 = 10;
            num2 = 20;
            Console.WriteLine(num1);
            Console.WriteLine(num1.HasValue);
            Console.WriteLine(num2);
            Console.WriteLine(num2.HasValue);

            num1 += 20;
            num2 += 30;
            Console.WriteLine(num1);
            Console.WriteLine(num1.HasValue);
            Console.WriteLine(num2);
            Console.WriteLine(num2.HasValue);
        }
    }
}
