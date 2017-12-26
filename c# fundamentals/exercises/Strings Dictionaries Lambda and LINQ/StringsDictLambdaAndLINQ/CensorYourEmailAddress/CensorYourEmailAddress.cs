using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorYourEmailAddress
{
    class CensorYourEmailAddress
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] str = input
                .Split('@').ToArray();
            string name = str[0];
            string domain = str[1];

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text.IndexOf(input) == i)
                {
                    text = text.Remove(i, name.Length);
                    text = text.Insert(i, new string('*', name.Length));
                }
            }
            
            Console.WriteLine(text);
        }
    }
}