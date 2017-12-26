using System;

namespace PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main(string[] args)
        {
            int perfectMatches = 0;
            
            string input = Console.ReadLine();
            while (input != "Enough dates!")
            {
                string[] data = input.Split('\\');
                string dayOfWeek = data[0];
                string number = data[1];
                string braSize = data[2];
                string name = data[3];

                int result = 0;
                int day = 0;
                switch (dayOfWeek)
                {
                    case "Monday": day = 1; break;
                    case "Tuesday": day = 2; break;
                    case "Wednesday": day = 3; break;
                    case "Thursday": day = 4; break;
                    case "Friday": day = 5; break;
                    case "Saturday": day = 6; break;
                    case "Sunday": day = 7; break;
                }
                result += day;
                
                for (int i = 0; i < number.Length; i++)
                {
                    result += int.Parse(number[i].ToString());
                }
                
                int num = 0;
                if (braSize.Length == 3)
                {
                    num = int.Parse(braSize.Substring(0, 2));
                }
                else
                {
                    num = int.Parse(braSize.Substring(0, 3));
                }
                char ch = braSize[braSize.Length - 1];
                result += (num * ch);

                char firstLetter = name[0];
                result -= (firstLetter * name.Length);

                if (result >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", name);
                    perfectMatches++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(perfectMatches);
        }
    }
}
