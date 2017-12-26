using System;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            decimal tvPrice = decimal.Parse(Console.ReadLine());
            int yearsToPay = int.Parse(Console.ReadLine());
            decimal bankInterestRate = decimal.Parse(Console.ReadLine());
            decimal friendInterestRate = decimal.Parse(Console.ReadLine());

            decimal bankLoan = tvPrice * (decimal)(Math.Pow((1 + (double)bankInterestRate), yearsToPay));
            decimal friendLoan = tvPrice * (1M + friendInterestRate);

            Console.WriteLine(
            "{0:F2} {1}",
            Math.Min(bankLoan, friendLoan),
            bankLoan < friendLoan ? "Bank" : "Friend");
        }
    }
}
