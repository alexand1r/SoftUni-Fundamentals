using System;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string message = Console.ReadLine();
            int sumLetters = 0;
            int mask = 0;
            string encrypted = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                sumLetters += input[i];
            }

            //while (sumLetters != 0)
            //{
            //    mask += sumLetters % 10;
            //    sumLetters /= 10;
            //}
            
            mask = Mask(sumLetters);
            while (mask >= 10)
            {
                sumLetters = mask;
                mask = 0;
                mask = Mask(sumLetters);
                //while (sumLetters != 0)
                //{
                //    mask += sumLetters % 10;
                //    sumLetters /= 10;
                //}
            }
            
            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (message[i] % mask == 0)
                {
                    encrypted += (char)(message[i] + mask);
                }
                else
                {
                    encrypted += (char)(message[i] - mask);
                }
            }

            Console.WriteLine(encrypted);
        }

        static int Mask(int sum)
        {
            int mask = 0;
            while (sum != 0)
            {
                mask += sum % 10;
                sum /= 10;
            }
            return mask;
        }
    }
}
