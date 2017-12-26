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
            List<int> list = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int num = 0;
            int count = 0;
            int maxCount = int.MinValue;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1]) count++;
                else count = 0;

                if (maxCount < count)
                {
                    maxCount = count;
                    num = list[i];
                }
            }

            for (int i = 0; i < maxCount + 1; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
