using System;

namespace ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());
            int blockSize = 7;
            int mid = blockSize / 2;
            int diff = 0;
            int diffCounter = 0;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < blockSize; j++)
                {
                    if (j >= mid - diff && j <= mid + diff) {
                        Console.Write(letter);

                        if (letter == 'G')
                        {
                            letter = 'A';
                        }
                        else
                        {
                            letter++;
                        }
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                if (diffCounter >= mid)
                {
                    diff--;
                }
                else
                {
                    diff++;
                }

                diffCounter++;

                if (diffCounter == blockSize)
                {
                    diffCounter = 0;
                    diff++;
                }

                Console.WriteLine();
            }
        }
    }
}
