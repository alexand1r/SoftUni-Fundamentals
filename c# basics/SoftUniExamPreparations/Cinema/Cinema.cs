using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double total = 0;

            switch (type)
            {
                case "Premiere": total = 12 * rows * cols; break;
                case "Normal": total = 7.50 * rows * cols; break;
                case "Discount": total = 5 * rows * cols; break;
            }
            
            Console.WriteLine("{0:F2} leva", total);
        }
    }
}
