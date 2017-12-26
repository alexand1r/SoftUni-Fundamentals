using System;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int[] coordinates = new int[10];
            for (int i = 0; i < 10; i++)
            {
                coordinates[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < coordinates.Length; i += 2)
            {
                if ((coordinates[i] >= 0 && coordinates[i] <= 3 * h) && (coordinates[i + 1] >= 0 && coordinates[i + 1] <= h))
                {
                    Console.WriteLine("inside");
                }
                else if ((coordinates[i] >= h && coordinates[i] <= 2 * h) && (coordinates[i + 1] >= h && coordinates[i + 1] <= 4 * h))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
