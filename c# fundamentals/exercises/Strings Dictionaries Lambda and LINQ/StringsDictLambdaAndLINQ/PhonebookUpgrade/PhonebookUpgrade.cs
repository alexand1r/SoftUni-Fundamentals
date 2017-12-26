using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            string command = Console.ReadLine();
            while (!command.Equals("END"))
            {
                string[] tokens = command.Split(' ');
                string letter = tokens[0];
                string name = string.Empty;
                switch (letter)
                {
                    case "A":
                        string number = tokens[2];
                        name = tokens[1];
                        if (!phonebook.ContainsKey(name))
                            phonebook.Add(name, number);
                        else phonebook[name] = number;
                        break;
                    case "S":
                        name = tokens[1];
                        if (phonebook.ContainsKey(name))
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        else Console.WriteLine($"Contact {name} does not exist.");
                        break;
                    case "ListAll":
                        foreach (var pair in phonebook)
                        {
                            Console.WriteLine($"{pair.Key} -> {pair.Value}");
                        }
                        break;
                    default: break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
