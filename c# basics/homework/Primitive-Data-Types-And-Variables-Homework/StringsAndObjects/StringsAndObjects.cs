using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            object sum = first + " " + second;
            string third = (string)sum;

            Console.WriteLine(sum);
            Console.WriteLine(third);
        }
    }
}
