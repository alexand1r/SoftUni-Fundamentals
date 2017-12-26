using System;
using System.Globalization;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number between in the range[0...999]");
            int number = int.Parse(Console.ReadLine());

            string[] digit = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] special = { "", "eleven", "twelve", "thirteen", "fourtheen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] round = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int temp = 0;


            if (number <= 999)    
            {

                if (number == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (number != 0 && number < 10)  
                {
                    for (int i = number; i < digit.Length; i = +11)
                    {
                        temp = i % 10;
                        Console.WriteLine("{0}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(digit[temp].ToLower()));

                    }
                }
                else if (number > 10 && number < 20)  
                {
                    for (int i = number; i >= special.Length; i = -i)
                    {
                        temp = i % 10;
                        Console.WriteLine("{0}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(special[temp].ToLower()));

                    }
                }
                else if (number % 10 == 0 && number < 99) 
                {
                    for (int i = number; i >= round.Length; i = -i)
                    {
                        temp = i / 10;
                        Console.WriteLine("{0}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(round[temp].ToLower()));
                    }
                }
                else if (number >= 20 && number <= 99) 
                {
                    for (int i = number; i >= round.Length; i = -i)
                    {
                        temp = i / 10;
                        Console.Write("{0}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(round[temp].ToLower()));
                    }
                    for (int i = number; i >= digit.Length; i = -i)
                    {
                        temp = i % 10;
                        Console.WriteLine(" " + "{0}", digit[temp]);
                    }

                }
                else if (number >= 100 && number % 100 == 0) 
                {
                    for (int i = number; i >= digit.Length; i = -i)
                    {
                        temp = i / 100;
                        Console.WriteLine("{0}" + " " + "hundred", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(digit[temp].ToLower()));
                    }
                }
                else if (number > 100 && number / 10 == 10) 
                {
                    for (int i = number; i >= digit.Length; i = -i)
                    {
                        temp = i / 100;
                        Console.Write("{0}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(digit[temp].ToLower()));
                        Console.Write(" " + "hundred");
                        temp = i % 10;
                        Console.Write(" " + "and" + " " + "{0}", digit[temp]);
                        Console.WriteLine();
                    }
                }
                else if (number > 110 && number < 920 && (number / 10) % 10 == 1) 
                {
                    for (int i = number; i >= digit.Length; i = -i)
                    {
                        temp = i / 100;
                        Console.Write("{0}" + " " + "hundred" + " " + "and", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(digit[temp].ToLower()));
                    }
                    for (int i = number; i >= special.Length; i = -i)
                    {
                        temp = i % 10;
                        Console.WriteLine(" " + "{0}", special[temp]);
                    }
                }
                else if (number >= 110 && number <= 999) 
                {
                    for (int i = number; i >= digit.Length; i = -i)
                    {
                        temp = i / 100;
                        Console.Write("{0}" + " " + "hundred" + " " + "and", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(digit[temp].ToLower()));
                    }
                    for (int i = number; i >= round.Length; i = -i)
                    {
                        temp = (i / 10) % 10;
                        Console.Write(" " + "{0}", round[temp]);
                    }
                    for (int i = number; i >= digit.Length; i = -i)
                    {
                        temp = i % 10;
                        Console.WriteLine(" " + "{0}", digit[temp]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Out of range! Please enter the number in the range [0 ....999]");
            }
        }
    }
}
