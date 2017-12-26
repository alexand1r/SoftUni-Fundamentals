using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string middleName = "J.";
            string lastName = "Jonson";
            int balance = 30000000;
            string bankName = "Union Bank";
            string iban = "GB29NWBK60161331926819";
            ulong card1 = 3649682059381748;
            ulong card2 = 5478236514526985;
            ulong card3 = 2356953595826648;

            Console.WriteLine(@"
First name: {0}
Middle name: {1}
Last name: {2}
Balance: {3}
Bank name: {4}
IBAN: {5}
Credit card number (1): {6}
Credit card number (2): {7}
Credit card number (3): {8}"
, firstName, middleName, lastName, balance, bankName, iban, card1, card2, card3);
        }
    }
}
