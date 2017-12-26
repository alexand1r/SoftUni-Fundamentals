using System;
using System.Collections;

namespace _5.SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ArrayList sort = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                sort.Add(int.Parse(Console.ReadLine()));
            }

            sort.Sort();

            foreach (var item in sort)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
