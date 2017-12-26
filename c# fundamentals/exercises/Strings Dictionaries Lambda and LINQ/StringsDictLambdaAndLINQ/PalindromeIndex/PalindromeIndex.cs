using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (IsPalindrome(word))
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (IsPalindrome(word.Remove(i, 1)))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
        static bool IsPalindrome(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
                if (text[i] != text[text.Length - 1 - i]) return false;
            return true;
        }
    }
}
