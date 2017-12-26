using System;
using System.Linq;

namespace ReversedChars
{
    class ReversedChars
    {
        static void Main(string[] args)
        {
            string output = String.Empty;

            for (int i = 0; i < 3; i++)
            {
                char current = char.Parse(Console.ReadLine());
                output += current;
            }

            output = new string(Enumerable.Range(1, output.Length)
                .Select(i => output[output.Length - i]).ToArray());
            Console.WriteLine(output);
        }
    }
}
