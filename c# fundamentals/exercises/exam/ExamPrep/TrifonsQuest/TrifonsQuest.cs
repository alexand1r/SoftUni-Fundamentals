using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrifonsQuest
{
    class TrifonsQuest
    {
        static void Main(string[] args)
        {
            var health = long.Parse(Console.ReadLine());
            var dimensions = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            int turns = 0;

            var matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var str = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = str[j];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        char ch = matrix[row, col];
                        ++turns;
                        if (ch == 'F')
                        {
                            health -= (int)((turns - 1) / 2);
                            if (health <= 0)
                            {
                                Console.WriteLine($"Died at: [{row}, {col}]");
                                break;
                            }
                        }
                        else if (ch == 'H')
                        {
                            health += (int)((turns - 1) / 3);
                        }
                        else if (ch == 'T')
                        {
                            turns += 2;
                        }
                    }

                else
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        char ch = matrix[row, col];
                        ++turns;
                        if (ch == 'F') {
                            health -= (int)((turns - 1) / 2);
                            if (health <= 0)
                            {
                                Console.WriteLine($"Died at: [{row}, {col}]");
                                break;
                            }
                        }
                        else if (ch == 'H')
                        {
                            health += (int)((turns - 1) / 3);
                        }
                        else if (ch == 'T')
                        {
                            turns += 2;
                        }
                    }
                if (health <= 0) break;
            }

            if (health > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {health}");
                Console.WriteLine($"Turns: {turns}");
            }
        }
    }
}
