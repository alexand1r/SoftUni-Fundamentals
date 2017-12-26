using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int jumps = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            string[] numbers = input.Split(' ');
            int[] parsedNumbers = new int[numbers.Length];

            parsedNumbers = Array.ConvertAll(numbers, int.Parse);
            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                int index = i;
                int currentSum = parsedNumbers[index];
                for (int j = 0; j < jumps; j++)
                {
                    index += parsedNumbers[index];
                    if (index > parsedNumbers.Length-1)
                    {
                        index = index % parsedNumbers.Length;
                    }
                    currentSum += parsedNumbers[index];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine("max sum = {0}", maxSum);
        }
    }
}
