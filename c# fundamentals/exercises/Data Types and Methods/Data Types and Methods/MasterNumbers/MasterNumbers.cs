using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 0; i <= range; i++)
            {
                if (isPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            while (i > 0)
            {
                int lastDigit = i % 10;
                i /= 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool SumOfDigits(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }

            return false;            
        }

        private static bool isPalindrome(int i)
        {
            string digits = "" + i;
            for (int j = 0; j < digits.Length / 2; j++)
                if (digits[j] != digits[digits.Length - j - 1])
                {
                    return false;
                }
            return true;
        }
    }
}
