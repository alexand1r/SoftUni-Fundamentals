using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primeNums = FindPrimesInRange(startNum, endNum);
            if (primeNums.Count == 0)
            {
                Console.WriteLine("(empty list)");
            }
            Console.Write(primeNums[0]);
            for (int i = 1; i < primeNums.Count; i++)
            {
                Console.Write(", " + primeNums[i]);
            }
        }

        static List<int> FindPrimesInRange(int startNum, int endNum) {
            List<int> list = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (isPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number <= 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
