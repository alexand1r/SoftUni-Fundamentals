using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.XBits
{
    class XBitsBitSolution
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            int countX = 0;
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 6; i++)
            {
                int mask = 7; // 111
                // 5 = 101
                // 2 = 010
                // 5 = 101
                for (int j = 0; j < 30; j++)
                {
                    int firstRow = numbers[i] >> j;
                    int secondRow = numbers[i + 1] >> j;
                    int thirdRow = numbers[i + 2] >> j;
                    firstRow &= mask;
                    secondRow &= mask;
                    thirdRow = thirdRow & mask;

                    if (firstRow == 5 && secondRow == 2 && thirdRow == 5)
                    {
                        countX++;
                    }
                }
            }
            Console.WriteLine(countX);
        }
    }
}
