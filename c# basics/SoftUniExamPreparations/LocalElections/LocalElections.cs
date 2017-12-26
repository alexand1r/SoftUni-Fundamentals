using System;

namespace LocalElections
{
    class LocalElections
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int choice = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            string line = new string('.', 13); Console.WriteLine(line);

            for (int i = 1; i <= n; i++)
            {
                string a = "...+-----+..."; Console.WriteLine(a);
                
                if (i == choice)
                {
                    if (sign.ToString().ToLower() == "x")
                    {
                        string b = "...|.\\./.|..."; Console.WriteLine(b);
                        string c = i.ToString("00") + ".|.." + sign.ToString().ToUpper() + "..|..."; Console.WriteLine(c);
                        string d = "...|./.\\.|..."; Console.WriteLine(d);
                    }

                    else if (sign.ToString().ToLower() == "v")
                    {
                        string b = "...|\\.../|..."; Console.WriteLine(b);
                        string c = i.ToString("00") + ".|.\\./.|..."; Console.WriteLine(c);
                        string d = "...|.." + sign.ToString().ToUpper() + "..|..."; Console.WriteLine(d);
                    }
                }
                else
                {
                    string b = "...|.....|..."; Console.WriteLine(b);
                    string c = i.ToString("00") + ".|.....|..."; Console.WriteLine(c);
                    Console.WriteLine(b);
                }

                Console.WriteLine(a);
                Console.WriteLine(line);
            }
        }
    }
}
