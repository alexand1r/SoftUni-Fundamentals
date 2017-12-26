using System;
using System.Collections.Generic;

namespace ByteParty
{
    class ByteParty
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<uint> numbers = new List<uint>();
            for (int i = 0; i < n; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            string command = Console.ReadLine();
            while (command != "party over")
            {
                string[] input = command.Split();
                int[] orders = Array.ConvertAll(input, int.Parse);
                int order = orders[0];
                int position = orders[1];

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (order == -1)
                    {
                        uint mask = 1u << position;
                        numbers[i] ^= mask;
                    }
                    else if (order == 0)
                    {
                        uint mask = ~(1u << position);
                        numbers[i] &= mask;
                    }
                    else if (order == 1)
                    {
                        uint mask = 1u << position;
                        numbers[i] |= mask;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
