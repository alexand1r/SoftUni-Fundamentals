using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int longestSeq = 0;
            int seq = 0;
            int num = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    seq++;
                }
                else
                {
                    seq = 0;
                }

                if (longestSeq < seq)
                {
                    num = arr[i];
                    longestSeq = seq;
                }
  
            }

            for (int i = 0; i < longestSeq + 1; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
