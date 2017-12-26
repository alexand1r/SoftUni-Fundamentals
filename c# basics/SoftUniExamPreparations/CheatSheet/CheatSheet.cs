using System;

namespace CheatSheet
{
    class CheatSheet
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            long vNumber = long.Parse(Console.ReadLine());
            long hNumber = long.Parse(Console.ReadLine());

            for (long row = vNumber; row < vNumber + rows; row++)
            {
                for (long col = hNumber; col < hNumber + cols; col++)
                {
                    Console.Write(row * col);

                    if (col < hNumber + cols - 1)
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
