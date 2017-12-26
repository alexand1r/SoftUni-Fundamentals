using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split()
                .Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split()
                .Select(char.Parse).ToArray();

            int len = Math.Min(arr1.Length, arr2.Length);
            int bigger = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    if (arr1[i] > arr2[i])
                    {
                        bigger = 1;
                        break;
                    }
                    else
                    {
                        bigger = 2;
                        break;
                    }
                }
            }

            string final1 = string.Empty;
            string final2 = string.Empty;

            if (bigger == 0)
            {
                final1 = arr1.Length > arr2.Length ?
                    string.Join("", arr2) : string.Join("", arr1);
                final2 = final1.Equals(string.Join("", arr1)) ?
                    string.Join("", arr2) : string.Join("", arr1);
            }
            else
            {
                final1 = bigger == 1 ?
                    string.Join("", arr2) : string.Join("", arr1);
                final2 = bigger == 2 ?
                    string.Join("", arr2) : string.Join("", arr1);
            }

            Console.WriteLine(final1);
            Console.WriteLine(final2);
        }
    }
}
