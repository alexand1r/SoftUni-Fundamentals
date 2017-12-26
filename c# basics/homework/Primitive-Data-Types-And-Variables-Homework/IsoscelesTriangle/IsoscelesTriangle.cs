using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char character = '\u00A9';

            Console.WriteLine("   {0}", character);
            Console.WriteLine("  {0} {0}", character);
            Console.WriteLine(" {0}   {0}", character);
            Console.WriteLine("{0} {0} {0} {0}", character);

        }
    }
}
