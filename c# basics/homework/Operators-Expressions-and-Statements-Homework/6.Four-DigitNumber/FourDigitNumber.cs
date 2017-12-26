using System;

namespace _6.Four_DigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
                int firstDigit = n / 1000;
                int secondDigit = (n / 100) % 10;
                int thirdDigit = (n / 10) % 10;
                int fourthDigit = n % 10;

            if (n > 999 && n < 10000)
            {
                Console.WriteLine("Sum Of Digits: {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
                Console.WriteLine("Reversed n: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
                Console.WriteLine("Last Digit In Front: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
                Console.WriteLine("Exchange Second And Third Digit: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
            }
            else
            {
                Console.WriteLine("The number should be exactly 4 digits and cannot start with '0'");
            }
                
        }
    }
}
