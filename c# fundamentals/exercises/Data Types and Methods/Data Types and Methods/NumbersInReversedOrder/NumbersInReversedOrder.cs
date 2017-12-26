using System;
using System.Linq;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string reversed = new string(Enumerable.Range(1, num.Length)
                .Select(i => num[num.Length - i]).ToArray());
            Console.WriteLine(reversed);
        }
    }
}
