using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", (char)arr[i], (int)arr[i] - 97);
            }
        }
    }
}
