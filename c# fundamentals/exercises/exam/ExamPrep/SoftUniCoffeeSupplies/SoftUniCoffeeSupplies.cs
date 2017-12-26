using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class SoftUniCoffeeSupplies
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<string, string>();
            var coffees = new Dictionary<string, long>();

            var separators = Console.ReadLine().Split(' ').ToArray();
            string sep1 = separators[0];
            string sep2 = separators[1];

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd.Equals("end of info"))
                    break;
                if (cmd.Contains(sep1))
                    cmd = AddToPersons(persons, coffees, sep1, cmd);
                else
                    cmd = AddToCoffees(coffees, sep2, cmd);
            }

            foreach (var coffeeType in coffees)
            {
                if (coffeeType.Value <= 0)
                    Console.WriteLine("Out of {0}", coffeeType.Key);
            }

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd.Equals("end of week"))
                    break;
                AddToFinishedCoffees(persons, coffees, cmd);
            }

            Print(persons, coffees);
        }

        private static void AddToFinishedCoffees(Dictionary<string, string> persons, Dictionary<string, long> coffees, string cmd)
        {
            string[] tokens = cmd.Split(' ').ToArray();
            string name = tokens[0];
            long quantity = long.Parse(tokens[1]);
            string str = persons[name];
            coffees[str] -= quantity;
            if (coffees[str] <= 0)
            {
                foreach (var item in coffees)
                {
                    if (item.Key == str)
                    {
                        Console.WriteLine("Out of " + item.Key);
                    }
                }
                //Console.WriteLine("Out of {0}", coffees[str]);
            }
        }

        private static void Print(Dictionary<string, string> persons, Dictionary<string, long> coffees)
        {
            Console.WriteLine("Coffee Left:");
            var coffeesLeft = coffees.Where(c => c.Value > 0)
                .ToDictionary(coffeeType => coffeeType.Key, coffeeType => coffeeType.Value);

            foreach (var coffeeType in coffeesLeft.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{coffeeType.Key} {coffeeType.Value}");
            }

            Console.WriteLine("For:");
            var coffeeTypeByPeople = persons.Where(c => coffeesLeft.ContainsKey(c.Value))
                .OrderBy(c => c.Value).ThenByDescending(p => p.Key);

            foreach (var keyValuePair in coffeeTypeByPeople)
            {
                Console.WriteLine($"{keyValuePair.Key} {keyValuePair.Value}");
            }
        }

        private static string AddToPersons(Dictionary<string, string> persons, Dictionary<string, long> coffees, string sep1, string cmd)
        {
            {
                cmd = cmd.Replace(sep1, ".");
                string[] tokens = cmd.Split('.').ToArray();
                string personName = tokens[0];
                string coffeeType = tokens[1];

                if (persons.ContainsKey(personName))
                    persons[personName] = coffeeType;
                else
                    persons.Add(personName, coffeeType);

                if (!coffees.ContainsKey(coffeeType))
                {
                    coffees.Add(coffeeType, 0);
                }
            }

            return cmd;
        }

        private static string AddToCoffees(Dictionary<string, long> coffees, string sep2, string cmd)
        {
            {
                cmd = cmd.Replace(sep2, ".");
                string[] tokens = cmd.Split('.').ToArray();
                string coffeeName = tokens[0];
                long coffeeQuantity = long.Parse(tokens[1]);

                if (coffees.ContainsKey(coffeeName))
                    coffees[coffeeName] += coffeeQuantity;
                else
                    coffees.Add(coffeeName, coffeeQuantity);
            }

            return cmd;
        }
    }
}
