using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ',', ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            List<string> palindromes = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i]
                    .Equals(new string(words[i]
                                        .Reverse()
                                        .ToArray())))
                {
                    palindromes.Add(words[i]);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
//public static void Main()
//{
//    char[] separators = " ,.?!".ToCharArray();
//    string[] words = Console.ReadLine()
//        .Split(separators, StringSplitOptions.RemoveEmptyEntries)
//        .OrderBy(x => x)
//        .Distinct().ToArray();
//    List<string> palindromes = new List<string>();
//    foreach (string word in words)
//        if (IsPalindrome(word)) palindromes.Add(word);
//    Console.WriteLine(string.Join(", ", palindromes));
//}

//static bool IsPalindrome(string text)
//{
//    for (int i = 0; i < text.Length / 2; i++)
//        if (text[i] != text[text.Length - 1 - i]) return false;
//    return true;
//}