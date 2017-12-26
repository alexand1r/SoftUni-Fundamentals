using System;

namespace Problem_4.N_th_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double result = (number / (Math.Pow(10, n - 1))) % 10;
            Console.WriteLine((int)result);
        }
    }
}
