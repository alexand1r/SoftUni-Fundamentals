using System;
using System.Text;

namespace SpyHard
{
    class SpyHard
    {
        static void Main(string[] args)
        {
            int count = 0;
            int beginning = int.Parse(Console.ReadLine());
            Console.Write(beginning);
            string word = Console.ReadLine().ToLower();
            Console.Write(word.Length);

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    count += word[i] - 96;
                }
                else
                {
                    count += word[i];
                }
            }

            StringBuilder numeralSystemConverter = new StringBuilder();

            while (count > 0)
            {
                numeralSystemConverter.Insert(0, count % beginning);
                count /= beginning;
            }

            Console.WriteLine(numeralSystemConverter);
        }
    }
}
