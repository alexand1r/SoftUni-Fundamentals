using System;

namespace _2.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Company Address: ");
            string companyAddress = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Web Site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Manager age: ");
            int managerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb Site: {4}\nManager: {5} {6} (age: {7}, tel. {8}"
                , companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName
                , managerAge, managerPhone);
        }
    }
}
