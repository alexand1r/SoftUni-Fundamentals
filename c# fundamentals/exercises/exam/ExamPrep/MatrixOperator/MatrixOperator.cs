using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator
{
    class MatrixOperator
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new List<List<long>>();

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split(' ')
                    .Select(long.Parse).ToList();
                matrix.Add(list);
            }

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd.Equals("end"))
                    break;
                string[] tokens = cmd.Split(' ').ToArray();
                if (tokens[0].Equals("remove"))
                {
                    string evenOdd = tokens[1];
                    string rowCol = tokens[2];
                    int index = int.Parse(tokens[3]);

                    if (rowCol.Equals("row"))
                    {
                        RemoveRow(matrix, index, evenOdd);
                    }
                    else
                    {
                        RemoveCol(n, matrix, index, evenOdd);                        
                    }
                }
                else if (tokens[0].Equals("swap"))
                {
                    Swap(matrix, tokens);
                }
                else if (tokens[0].Equals("insert"))
                {
                    Insert(matrix, tokens);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        private static void Insert(List<List<long>> matrix, string[] tokens)
        {
            int row = int.Parse(tokens[1]);
            long element = long.Parse(tokens[2]);

            matrix[row].Insert(0, element);
        }

        private static void Swap(List<List<long>> matrix, string[] tokens)
        {
            int row1 = int.Parse(tokens[1]);
            int row2 = int.Parse(tokens[2]);

            var temp = matrix[row1];
            matrix[row1] = matrix[row2];
            matrix[row2] = temp;
        }

        private static void RemoveRow(List<List<long>> matrix, int index, string evenOdd)
        {
            if (evenOdd.Equals("even"))
                matrix[index] = matrix[index].Where(s => (long)Math.Abs(s) % 2 == 1).ToList();
            else if (evenOdd.Equals("odd"))
                matrix[index] = matrix[index].Where(s => (long)Math.Abs(s) % 2 == 0).ToList();
            else if (evenOdd.Equals("positive"))
                matrix[index] = matrix[index].Where(s => s < 0).ToList();
            else if (evenOdd.Equals("negative"))
                matrix[index] = matrix[index].Where(s => s >= 0).ToList();
        }

        private static void RemoveCol(int n, List<List<long>> matrix, int index, string evenOdd)
        {
            for (int i = 0; i < n; i++)
            {
                if (index <= matrix[i].Count() - 1)
                {
                    long num = (long)Math.Abs(matrix[i][index]);
                    if (evenOdd.Equals("even"))
                    {
                        if (num % 2 == 0)
                            matrix[i].RemoveAt(index);
                    }
                    else if (evenOdd.Equals("odd"))
                    {
                        if (num % 2 == 1)
                            matrix[i].RemoveAt(index);
                    }
                    else if (evenOdd.Equals("positive"))
                    {
                        if (matrix[i][index] >= 0)
                            matrix[i].RemoveAt(index);
                    }
                    else if (evenOdd.Equals("negative"))
                    {
                        if (matrix[i][index] < 0)
                            matrix[i].RemoveAt(index);
                    }
                }
            }
        }
    }
}
