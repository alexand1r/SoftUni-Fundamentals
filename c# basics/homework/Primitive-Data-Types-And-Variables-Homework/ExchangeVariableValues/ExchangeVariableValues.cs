using System;
namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}\n", b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}\n", b);
        }
    }
}
