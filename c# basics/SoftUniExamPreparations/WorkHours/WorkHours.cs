using System;

namespace WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            decimal h = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            decimal productivity = p / 100m;
            decimal workDays = d - (10m * d / 100m);
            decimal effWorkHours = workDays * 12m * productivity;
            int result = (int)effWorkHours;

            Console.WriteLine("{0}", result >= h ? "Yes":"No");
            Console.WriteLine("{0}", result - h);
        }
    }
}
