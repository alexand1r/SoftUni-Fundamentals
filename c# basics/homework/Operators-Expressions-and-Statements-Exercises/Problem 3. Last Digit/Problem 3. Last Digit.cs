using System;

namespace Problem_3.Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 100;
            Console.WriteLine(lastDigit);
        }
    }
}
