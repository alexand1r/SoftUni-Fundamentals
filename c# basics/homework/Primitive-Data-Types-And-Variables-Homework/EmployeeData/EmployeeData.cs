using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            sbyte age = 27;
            char gender = 'f';
            ulong id = 8306112507;
            uint number = 27563571;

            Console.WriteLine(@"
First name: {0}
Last name: {1}
Age: {2}
Gender: {3}
Personal ID: {4}
Unique Employee Number: {5}"
, firstName, lastName, age, gender, id, number);
        }
    }
}
