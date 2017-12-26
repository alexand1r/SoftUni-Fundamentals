using System;
using System.Collections.Generic;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            string[] nums1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < nums1.Length; i++)
            {
                list1.Add(Convert.ToInt32(nums1[i]));
            }

            List<int> list2 = new List<int>();
            string[] nums2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < nums2.Length; i++)
            {
                list2.Add(Convert.ToInt32(nums2[i]));
            }

            List<int> newList = new List<int>();

            foreach (var item in list1)
            {
                if (newList.Contains(item))
                {
                    continue;
                }
                else
                { 
                    newList.Add(item);
                }
            }

            foreach (var item in list2)
            {
                if (newList.Contains(item))
                {
                    continue;
                }
                else
                {
                    newList.Add(item);
                }
            }

            newList.Sort();

            foreach (var item in newList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
