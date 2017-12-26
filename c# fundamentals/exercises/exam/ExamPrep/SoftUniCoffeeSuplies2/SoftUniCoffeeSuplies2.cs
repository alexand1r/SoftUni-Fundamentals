using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSuplies2
{
    class SoftUniCoffeeSuplies2
    {
        static void Main(string[] args)
        {
            string[] delimeters = Console.ReadLine().Split(' ').ToArray();
            string input = Console.ReadLine();

            Dictionary<string, string> personName = new Dictionary<string, string>();
            Dictionary<string, long> coffeType = new Dictionary<string, long>();

            while (input != "end of info")
            {
                if (input.Contains(delimeters[0]))
                {
                    string[] array = input.Split(new string[] { delimeters[0] }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    personName.Add(array[0], array[1]);
                }
                if (input.Contains(delimeters[1]))
                {
                    var array = input.Split(new string[] { delimeters[1] }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (!coffeType.ContainsKey(array[0]))
                    {
                        coffeType.Add(array[0], long.Parse(array[1]));
                    }
                    else
                    {
                        coffeType[array[0]] += long.Parse(array[1]);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in personName)
            {
                if (!coffeType.ContainsKey(item.Value))
                {
                    Console.WriteLine("Out of " + item.Value);
                }
            }

            var input1 = Console.ReadLine();

            while (input1 != "end of week")
            {
                var array = input1.Split(' ').ToArray();
                coffeType[personName[array[0]]] -= long.Parse(array[1]);
                if (coffeType[personName[array[0]]] <= 0)
                {
                    foreach (var item in coffeType)
                    {
                        if (item.Key == personName[array[0]])
                        {
                            Console.WriteLine("Out of " + item.Key);
                        }
                    }
                }
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left:");
            foreach (var item in coffeType.OrderByDescending(x => x.Value))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }

            Console.WriteLine("For:");
            foreach (var element in coffeType.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                foreach (var item in personName.OrderByDescending(x => x.Key))
                {
                    if (item.Value == element.Key)
                    {
                        Console.WriteLine(item.Key + " " + element.Key);
                    }
                }
            }
        }
    }
}