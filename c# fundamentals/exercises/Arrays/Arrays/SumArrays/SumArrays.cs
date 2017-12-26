using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int arr3Lenght = Math.Max(arr1.Length, arr2.Length);
            int[] arr3 = new int[arr3Lenght];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(String.Join(" ", arr3));
        }
    }
}
