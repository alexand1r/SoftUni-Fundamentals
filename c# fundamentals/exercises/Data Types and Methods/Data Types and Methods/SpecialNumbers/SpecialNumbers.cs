using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = SpecialCheck(i);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }

        private static bool SpecialCheck(int num)
        {
            int sum = sumDigits(num);

            bool special = (sum == 5) ||
                           (sum == 7) ||
                           (sum == 11);

            return special;
        }

        private static int sumDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }

            return sum;
        }
    }
}
