using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int[] counts = new int[str.Max() + 1];

            for (int i = 0; i < str.Length; i++)
            {
                counts[str[i]]++;
            }

            //Array.Sort(counts);
            //str = new string(str.Distinct().ToArray());
            str = new string(String.Concat(str.OrderBy(c => c)).Distinct().ToArray());
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", str[i], counts[str[i]]);
            }
        }
    }
}
