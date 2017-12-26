using System;
using System.Collections.Generic;

namespace _9.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            string[] namesLine1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < namesLine1.Length; i++)
            {
                list1.Add(namesLine1[i]); 
            }

            List<string> list2 = new List<string>();
            string[] namesLine2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < namesLine2.Length; i++)
            {
                list2.Add(namesLine2[i]);
            }

            List<string> newList = new List<string>();
   
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    continue;
                }
                else
                {
                    newList.Add(item);
                }
            }

            foreach (var item in newList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
