using System;

namespace WinningNumbers
{
    class WinningNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int letterSum = 0;
            bool solutionFound = false;
            for (int i = 0; i < input.Length; i++) 
            {
                letterSum += input[i] - 96;
            }
            for (int digit1 = 1; digit1 < 10; digit1++)
            {
                for (int digit2 = 1; digit2 < 10; digit2++)
                {
                    for (int digit3 = 1; digit3 < 10; digit3++)
                    {
                        for (int digit4 = 1; digit4 < 10; digit4++)
                        {
                            for (int digit5 = 1; digit5 < 10; digit5++)
                            {
                                for (int digit6 = 1; digit6 < 10; digit6++)
                                {
                                    int firstThreeDigits = digit1 * digit2 * digit3;
                                    int secondThreeDigits = digit4 * digit5 * digit6;
                                    if (firstThreeDigits == secondThreeDigits)
                                    {
                                        if (firstThreeDigits == letterSum)
                                        {
                                            Console.WriteLine("{0}{1}{2}-{3}{4}{5}"
                                                , digit1, digit2, digit3
                                                , digit4, digit5, digit6);
                                            solutionFound = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!solutionFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
