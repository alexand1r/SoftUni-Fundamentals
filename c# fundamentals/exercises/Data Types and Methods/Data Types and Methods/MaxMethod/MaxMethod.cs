using System;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int firstCheck = MaxOfTwo(a, b);
            int secondCheck = MaxOfTwo(b, c);
            int thirdCheck = MaxOfTwo(a, c);
            if (firstCheck > max)
            {
                max = firstCheck;
            }
            if (secondCheck > max)
            {
                max = secondCheck;
            }
            if (thirdCheck > max)
            {
                max = thirdCheck;
            }
            Console.WriteLine(max);
        }

        private static int MaxOfTwo(int a, int b)
        {
            int num = Math.Max(a, b);
            return num;
        }
    }
}
