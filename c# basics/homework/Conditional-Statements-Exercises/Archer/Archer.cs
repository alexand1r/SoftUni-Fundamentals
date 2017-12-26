using System;

namespace Archer
{
    class Archer
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool valid = r * r >= x * x + y * y;

            if (valid)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
