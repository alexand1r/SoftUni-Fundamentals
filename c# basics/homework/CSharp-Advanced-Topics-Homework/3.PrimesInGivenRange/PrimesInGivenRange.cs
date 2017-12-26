using System;
using System.Collections.Generic;

namespace _3.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            foreach(var item in FindPrimesInRange(start, end))
            {
                Console.Write("{0} ", item);
            }
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            bool prime = true;
            int maxdivider = 0;
            for (int i = startNum; i < endNum; i++)
            {
                prime = isPrime(i);
                if (i == 0) prime = false;
                if (i == 1) prime = false;
                if (prime) list.Add(i);
            }
            return list;
        }

        static bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
