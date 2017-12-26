using System;

namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool found = false;
            
            try {
                sbyte num1 = sbyte.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* sbyte");
            }
            catch (OverflowException)
            {
            }
            try
            {
                byte num1 = byte.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* byte");
            }
            catch (OverflowException)
            {
            }
            try
            {
                short num1 = short.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* short");
            }
            catch (OverflowException)
            {
            }
            try
            {
                ushort num1 = ushort.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* ushort");
            }
            catch (OverflowException)
            {
            }
            try
            {
                int num1 = int.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* int");
            }
            catch (OverflowException)
            {
            }
            try
            {
                uint num1 = uint.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* uint");
            }
            catch (OverflowException)
            {
            }
            try
            {
                long num1 = long.Parse(num);
                if (!found)
                {
                    found = true;
                    Console.WriteLine("{0} can fit in:", num);
                }
                Console.WriteLine("* long");
            }
            catch (OverflowException)
            {
            }

            if (!found)
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }
        }
    }
}
