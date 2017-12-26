using System;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum1 = 0;
            long sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum1 += num;
            }

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum2 += num;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum={0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
