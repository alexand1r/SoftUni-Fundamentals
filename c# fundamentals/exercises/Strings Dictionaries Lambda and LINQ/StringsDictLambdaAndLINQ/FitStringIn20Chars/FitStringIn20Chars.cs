using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStringIn20Chars
{
    class FitStringIn20Chars
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text.Length < 20)
            {
                text += "*";
            }
            Console.WriteLine(string.Join(""
                , text.Take(20).ToList()));
        }
    }
}
