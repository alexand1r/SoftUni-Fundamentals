using System;
using System.Collections;

namespace _12.RandomizetheNumbersN
{
    class RandomizetheNumbersN
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            var nums = new ArrayList();
            Random rnd = new Random();

            while (nums.Count <= n)
            {
                int number = rnd.Next(1, n + 1);
                while (nums.Contains(number))
                {
                    number = rnd.Next(1, n);
                }
                nums.Add(number);
                Console.Write(number + " ");
            }          
        }
    }
}
