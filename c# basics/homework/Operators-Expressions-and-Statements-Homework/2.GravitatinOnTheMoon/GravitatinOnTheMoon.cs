using System;

namespace _2.GravitatinOnTheMoon
{
    class GravitatinOnTheMoon
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = 0.17 * weight;
            Console.WriteLine(weightOnTheMoon);
        }
    }
}
