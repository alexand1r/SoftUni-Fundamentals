using System;
using System.Text;

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            // ASCII is a 7bit code!
            Console.OutputEncoding = Encoding.ASCII;

            for (byte i = 32; i < 128; i++)
            {
                Console.Write(" {0}  ", (char)i);
            }
            Console.WriteLine();

        }
    }
}

