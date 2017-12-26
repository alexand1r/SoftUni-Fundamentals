using System;
using System.Text;
using System.Numerics;

namespace Petar_sGame
{
    class PetarGame
    {
        static void Main(string[] args)
        {
            ulong startingNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replacement = Console.ReadLine();
            BigInteger sum = 0;

            for (ulong i = startingNumber; i < endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }

            string result = sum.ToString();
            string digitToReplace = string.Empty;
                        
            if (sum % 2 == 0)
            {
                digitToReplace = result[0].ToString();
            }
            else
            {
                digitToReplace = result[result.Length - 1].ToString();
            }

            result = result.Replace(digitToReplace, replacement);

            Console.WriteLine(result);
        }
    }
}
