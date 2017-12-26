using System;

namespace _7.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');

            double firstNumber = double.Parse(numbers[0]);
            double secondNumber = double.Parse(numbers[1]);
            double thirdNumber = double.Parse(numbers[2]);
            double forthNumber = double.Parse(numbers[3]);
            double fifthNumber = double.Parse(numbers[4]);
            
            double sum = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;
            Console.WriteLine(sum);
        }
    }
}
