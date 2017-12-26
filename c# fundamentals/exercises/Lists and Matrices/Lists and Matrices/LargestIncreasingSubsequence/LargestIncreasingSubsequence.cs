using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestIncreasingSubsequence
{
    class LargestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            printLIS(list);
        }

        private static void printLIS(int[] list)
        {
            string[] paths = new string[list.Length];
            int[] sizes = new int[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                sizes[i] = 1;
                paths[i] = list[i] + " ";
            }

            int maxLength = 1;

            for (int i = 1; i < list.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[i] > list[j] && sizes[i] < sizes[j] + 1)
                    {
                        sizes[i] = sizes[j] + 1;
                        paths[i] = paths[j] + list[i] + " ";
                        if (maxLength < sizes[i])
                            maxLength = sizes[i];
                    }
                }
            }

            if (list.Length == 1)
            {
                Console.WriteLine(list[0]);
            }
            for (int i = 1; i < list.Length; i++)
            {
                if (sizes[i] == maxLength)
                {
                    Console.WriteLine(paths[i]);
                    break;
                }
            }
        }
    }
}
