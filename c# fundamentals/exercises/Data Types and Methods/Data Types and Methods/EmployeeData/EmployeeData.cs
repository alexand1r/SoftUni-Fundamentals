using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            decimal id = decimal.Parse(Console.ReadLine());
            decimal employee = decimal.Parse(Console.ReadLine());

            Console.WriteLine(@"
First name: {0}
Last name: {1}
Age: {2}
Gender: {3}
Personal ID: {4}
Unique Employee number: {5}"
, firstName, lastName, age, gender, id, employee);
        }
    }
}
