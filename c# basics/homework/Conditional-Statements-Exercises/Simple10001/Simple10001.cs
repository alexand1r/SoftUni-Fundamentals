using System;
using System.Collections;

namespace Simple10001
{
    class Simple10001
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            ArrayList primeNumbers = new ArrayList();
            int count = int.Parse(Console.ReadLine());

            for (int i = 2; primeNumbers.Count < count; i++)
            {
                bool divisible = false;

                foreach (int number in primeNumbers)
                {
                    if (i % number == 0)
                    {
                        divisible = true;
                        break;
                    }
                }

                if (divisible == false)
                {
                    primeNumbers.Add(i);
                }
            }
            Console.WriteLine(primeNumbers[primeNumbers.Count - 1].ToString());
        }
    }
}
