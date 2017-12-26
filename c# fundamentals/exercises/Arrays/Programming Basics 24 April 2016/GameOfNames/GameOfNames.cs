using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class GameOfNames
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            var names = new Dictionary<int, string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int initScore = int.Parse(Console.ReadLine());
                for (int j = 0; j < name.Length; j++)
                {
                    int current = (int)name[j];
                    if (current % 2 == 0)
                    {
                        initScore += current;
                    }
                    else
                    {
                        initScore -= current;
                    }
                }
                if (!names.ContainsKey(initScore))
                {
                    names.Add(initScore, name);
                }
            }

            int max = int.MinValue;
            List<int> list = new List<int>(names.Keys);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max) max = list[i];
            }

            Console.WriteLine("The winner is {0} - {1} points"
                , names[max], max);
        }
    }
}
