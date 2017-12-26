using System;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char current = char.Parse(Console.ReadLine());
            if (current == 'a' || current == 'e' || current == 'o' || current == 'i' || current == 'u')
            {
                Console.WriteLine("vowel");
            } 
            else if (current <= '9' && current >= '0')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
