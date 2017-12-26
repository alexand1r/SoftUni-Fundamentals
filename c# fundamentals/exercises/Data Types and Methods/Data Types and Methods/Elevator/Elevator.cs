using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int courses = 0;

            courses = n < c ? ++courses : (int)Math.Ceiling((double)n / c);

            Console.WriteLine(courses);
        }
    }
}
