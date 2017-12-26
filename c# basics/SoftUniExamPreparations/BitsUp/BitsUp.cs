using System;

namespace BitsUp
{
    class BitsUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    if ((index % step == 1) || (index > 0 && step == 1))
                    {
                        num |= 1 << bit;
                    }
                    index++;
                }
                Console.WriteLine(num);
            }
        }
    }
}
