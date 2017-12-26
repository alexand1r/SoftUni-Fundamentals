using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalization
{
    class Capitalization
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w[0].ToString().ToUpper()
                + w.Substring(1, w.Length - 1))
                .ToList();

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
