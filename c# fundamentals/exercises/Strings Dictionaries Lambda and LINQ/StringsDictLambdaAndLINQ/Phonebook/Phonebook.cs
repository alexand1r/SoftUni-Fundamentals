using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string command = Console.ReadLine();
            while (!command.Equals("END"))
            {
                string[] tokens = command.Split(' ');
                string letter = tokens[0];
                string name = tokens[1];
                switch (letter)
                {
                    case "A":
                        string number = tokens[2];
                        if (!phonebook.ContainsKey(name))
                            phonebook.Add(name, number);
                        else phonebook[name] = number;
                        break;
                    case "S":
                        if (phonebook.ContainsKey(name))
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        else Console.WriteLine($"Contact {name} does not exist.");
                        break;
                    default: break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
