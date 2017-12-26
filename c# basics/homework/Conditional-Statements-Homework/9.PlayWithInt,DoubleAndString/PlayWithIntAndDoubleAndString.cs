using System;

namespace _9.PlayWithInt_DoubleAndString
{
    class PlayWithIntAndDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int type;
            bool typeValid = int.TryParse(Console.ReadLine(), out type);
            
            if (typeValid)
            {
                switch (type)
                {
                    case 1:
                        {
                            int a = int.Parse(Console.ReadLine());
                            a++;
                            Console.WriteLine(a);
                            break;
                        }
                    case 2:
                        {
                            double b = double.Parse(Console.ReadLine());
                            b++;
                            Console.WriteLine(b);
                            break;
                        }
                    case 3:
                        {
                            string c = Console.ReadLine();
                            Console.WriteLine(c + "*");
                            break;
                        }
                    default: Console.WriteLine("invalid input");
                            break;
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
