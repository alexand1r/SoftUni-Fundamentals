using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    class Tour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int[] cities = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int sum = 0;
            sum += matrix[0, cities[0]];

            for (int i = 1; i < cities.Length; i++)
            {
                int currentCity = cities[i];
                int previousCity = cities[i - 1];

                sum += matrix[previousCity, currentCity];
            }

            Console.WriteLine(sum);
        }
    }
}
