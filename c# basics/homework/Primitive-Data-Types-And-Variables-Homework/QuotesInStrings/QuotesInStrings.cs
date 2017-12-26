using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string message1 = "The \" use \" of quotations causes difficulties.";
            string message2 = @"The "" use "" of quotations causes difficulties.";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
        }
    }
}
