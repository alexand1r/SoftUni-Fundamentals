using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 4;
            //b++;
            //Console.WriteLine(a + (b--));
            //Console.WriteLine(a+b);
            //Console.WriteLine((double)a/b);

            //int c = 21345;
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(c % (Math.Pow(10.0, n)));

            //bool a = true;
            //bool b = false;
            //Console.WriteLine(a ^ b);
            //Console.WriteLine(a ^ !b);
            //Console.WriteLine((a == b) ^ (a != b));
            //!(a && b) = !a || !b;

            int a = 13; //1101
            int b = 4;  //0100
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);

            int c = 40;
            Console.WriteLine(c >> 4);
        }
    }
}
