using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacepin
{
    class Nacepin
    {
        static void Main(string[] args)
        {
            decimal usPrice = decimal.Parse(Console.ReadLine());
            decimal usWeight = decimal.Parse(Console.ReadLine());
            decimal ukPrice = decimal.Parse(Console.ReadLine());
            decimal ukWeight = decimal.Parse(Console.ReadLine());
            decimal chPrice = decimal.Parse(Console.ReadLine());
            decimal chWeight = decimal.Parse(Console.ReadLine());

            var prices = new Dictionary<decimal, string>();

            decimal usFinal = (usPrice / 0.58m) / usWeight;
            decimal ukFinal = (ukPrice / 0.41m) / ukWeight;
            decimal chFinal = (chPrice * 0.27m) / chWeight;
            
            var list = new List<decimal>() { usFinal, ukFinal, chFinal};
            
            prices.Add(usFinal, "US");
            prices.Add(ukFinal, "UK");
            prices.Add(chFinal, "Chinese");

            decimal max = decimal.MinValue;
            decimal min = decimal.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max) max = list[i];
                if (list[i] < min) min = list[i];
            }
            decimal difference = max - min;

            Console.WriteLine("{0} store. {1:f2} lv/kg"
                , prices[min], min);
            Console.WriteLine("Difference {0:f2} lv/kg"
                , difference);
        }
    }
}
