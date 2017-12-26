using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');

            char[] firstArray = input[0].ToCharArray();
            char[] secondArray = input[1].ToCharArray();
            string command = input[2];

            List<char> newArr = new List<char>();

            if (command == "join")
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (secondArray.Contains(firstArray[i]))
                    {
                        newArr.Add(firstArray[i]);
                    }
                }
            }

            if (command == "right exclude")
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (!secondArray.Contains(firstArray[i]))
                    {
                        newArr.Add(firstArray[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (!firstArray.Contains(secondArray[i]))
                    {
                        newArr.Add(secondArray[i]);
                    }
                }
            }

            newArr.Sort();
            foreach (var element in newArr)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
