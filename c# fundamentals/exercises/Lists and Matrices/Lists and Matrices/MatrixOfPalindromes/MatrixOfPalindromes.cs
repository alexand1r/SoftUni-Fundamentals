using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int rows = list[0];
            int cols = list[1];

            for (int i = 0; i < rows; i++)
            {
                char currentRow = (char)(i + 97);
                for (int j = i; j < cols + i; j++)
                {
                    char currentCol = (char)(j + 97);
                    Console.Write("{0}{1}{2} "
                        , currentRow, currentCol, currentRow);
                }
                Console.WriteLine();
            }
        }
    }
}
