using System;
namespace _3.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Devided by 7 and 5? {0}",
                (n % 5 == 0) && (n % 7 == 0) ? true : false);
        }
    }
}
