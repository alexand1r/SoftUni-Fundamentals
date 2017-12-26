using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumOf_n_Numbers
{
    class SumOf_n_Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double a = 0;

            for(int i = 1; i <= n; i++)
                {
                    a = double.Parse(Console.ReadLine());
                    sum += a;
                }
            Console.WriteLine(sum);
        }
    }
}
