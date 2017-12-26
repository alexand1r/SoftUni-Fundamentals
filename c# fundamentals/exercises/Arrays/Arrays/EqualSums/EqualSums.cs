using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] arr1 = arr.Take(i).ToArray();
                int[] arr2 = arr.Skip(i + 1).Take(arr.Length - i).ToArray();
                if (arr1.Sum() == arr2.Sum())
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
