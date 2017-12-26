using System;

namespace _2.Power
{
    class Power
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Powera(a, b));
        }

        static double Powera(double number, double power)
        {
            double a = number;
            double b = power;
            double result = Math.Pow(a, b);
            return result;
        }
    }
}
