using System;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            num = num.Substring(2);
            int value = Convert.ToInt32(num, 16);
            Console.WriteLine(value);
        }
    }
}
