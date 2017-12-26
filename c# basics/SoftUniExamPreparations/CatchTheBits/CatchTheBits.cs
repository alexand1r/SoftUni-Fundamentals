using System;

namespace CatchTheBits
{
    class CatchTheBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            int output = 0;
            int outputBitsCount = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    if ((index % step == 1) || (step == 1 && index > 0))
                    {
                        int bitValue = (num >> bit) & 1;
                        output <<= 1;
                        output |= bitValue;
                        outputBitsCount++;
                        if (outputBitsCount == 8)
                        {
                            Console.WriteLine(output);
                            output = 0;
                            outputBitsCount = 0;
                        }
                    }
                    index++;
                }
            }
            if (outputBitsCount > 0)
            {
                output <<= 8 - outputBitsCount;
                Console.WriteLine(output);
            }
        }
    }
}
