using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonStrings
{
    class CommonStrings
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            bool containsCommonChar = false;
            foreach (char word1Char in word1)
            {
                if (word2.Contains(word1Char))
                {
                    containsCommonChar = true; break;
                }
            }
            Console.WriteLine(containsCommonChar ? "yes" : "no");
        }
    }
}
