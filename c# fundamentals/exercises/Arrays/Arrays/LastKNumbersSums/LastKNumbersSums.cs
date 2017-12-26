using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            decimal[] seq = new decimal[n];
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (i < k)
                {
                    seq[i] = seq.Sum();
                }
                else
                {
                    int temp = k;
                    while (temp > 0)
                    {
                        seq[i] += seq[i - temp];
                        temp--;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", seq));
        }
    }
}
