using System;

namespace NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool solution = false;

            for (int a = 1; a < 8; a++)
            {
                for (int b = 1; b < 8; b++)
                {
                    for (int c = 1; c < 8; c++)
                    {
                        for (int d = 1; d < 8; d++)
                        {
                            for (int e = 1; e < 8; e++)
                            {
                                for (int f = 1; f < 8; f++)
                                {
                                    for (int g = 1; g < 8; g++)
                                    {
                                        for (int h = 1; h < 8; h++)
                                        {
                                            for (int i = 1; i < 8; i++)
                                            {
                                                int abc = a * 100 + b * 10 + c;
                                                int def = d * 100 + e * 10 + f;
                                                int ghi = g * 100 + h * 10 + i;
                                                if (abc <= def && def <= ghi)
                                                {
                                                    if (ghi - def == def - abc && ghi - def == diff)
                                                    {
                                                        int sumDigits = a + b + c + d + e + f + g + h + i;
                                                        if (sumDigits == sum)
                                                        {
                                                            solution = true;
                                                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}"
                                                                , a, b, c, d, e, f, g, h, i);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!solution)
            {
                Console.WriteLine("No");
            }
        }
    }
}
