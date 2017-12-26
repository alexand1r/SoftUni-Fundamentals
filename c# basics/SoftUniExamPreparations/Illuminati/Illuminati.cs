using System;

namespace Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string movieLine = Console.ReadLine().ToUpper();
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            int counter = 0;
            int sum = 0;

            for (int i = 0; i < movieLine.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (movieLine[i] == vowels[j])
                    {
                        counter++;
                        sum += movieLine[i];
                    }
                }
            }

            Console.WriteLine("{0}\n{1}", counter, sum);
        }
    }
}
