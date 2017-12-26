using System;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(SayHello(name));
        }

        private static string SayHello(string name)
        {
            string sayHello = "Hello, " + name + "!";
            return sayHello;
        }
    }
}
