using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split().ToArray();
            string[] arr2 = Console.ReadLine()
                .Split().ToArray();

            var lcb = 0;
            var lce = 0;
            var len = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < len; i++)
            {
                if (arr1[i].Equals(arr2[i]))
                {
                    lcb++;
                }
                else
                {
                    break;
                }
            }

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            for (int i = 0; i < len; i++)
            {
                if (arr1[i].Equals(arr2[i]))
                {
                    lce++;
                }
                else
                {
                    break; 
                }
            }
            var result = 0;
            result = lce > lcb ? lce : lcb;
            Console.WriteLine(result);
        }
    }
}
