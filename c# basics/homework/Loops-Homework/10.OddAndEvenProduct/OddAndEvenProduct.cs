using System;
using System.Collections;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int productOdd = 1, productEven = 1;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(input[i]);
                numbers.Add(num);
            }
           
            for (int i = 0; i <= numbers.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    productOdd *= (int)numbers[i];
                }
                else
                {
                    productEven *= (int)numbers[i];
                }
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", productEven);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("productOdd = {0}", productOdd);
                Console.WriteLine("productEven = {0}", productEven);
            }
        }
    }
}
