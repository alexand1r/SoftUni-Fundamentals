using System;

namespace Problem_1.Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a program that finds the average of the sum of 3 numbers.
            //Hints:
            //	Declare four variables(a, b, c and average).
            //    Read the user input from the console. (int.Parse(Console.ReadLine());).
            //	Calculate the average value of the variables by the formulae (average = (a + b + c) / 3).
            //    Print the result on the console(Console.WriteLine(average));).

            int a;
            int b;
            int c;
            double average;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            average = (double)(a + b + c) / 3;
            Console.WriteLine(average);
                
        }
    }
}
