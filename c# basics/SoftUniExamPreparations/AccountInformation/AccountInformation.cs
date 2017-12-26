using System;

namespace AccountInformation
{
    class AccountInformation
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string id = Console.ReadLine();
            double total = double.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}", firstName, lastName);
            Console.WriteLine("Client id: {0}", id);
            Console.WriteLine("Total balance: {0:F2}", total);
            Console.WriteLine("Active: {0}", total >= 0 ? "yes":"no");
        }
    }
}
