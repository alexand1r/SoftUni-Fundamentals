using System;

namespace _4.TextModification
{
    class TextModification
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] % 3 == 0)
                {
                    Console.Write(str[i].ToString().ToUpper());
                }
                else
                {
                    Console.Write(str[i].ToString());
                }
            }
            Console.WriteLine();
        }
    }
}
