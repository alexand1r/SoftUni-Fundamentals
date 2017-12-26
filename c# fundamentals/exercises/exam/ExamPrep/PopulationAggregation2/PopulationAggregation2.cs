using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PopulationAggregation2
{
    class PopulationAggregation2
    {
        static void Main(string[] args)
        {
            var townsByCountry = new SortedDictionary<string, List<string>>();
            var populationByTown = new Dictionary<string, decimal>();

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd.Equals("stop"))
                   break;
                var cmdTokens = cmd.Split('\\');
                var country = RemoveBadChars(cmdTokens[0]);
                //var country = Regex.Replace(cmdTokens[0], "[0-9@#&$]*", "");
                var town = RemoveBadChars(cmdTokens[1]);
                //var town = Regex.Replace(cmdTokens[1], "[0-9@#&$]*", "");
                if (!char.IsUpper(country[0]))
                {
                    var old = country;
                    country = town;
                    town = old;
                }

                if (townsByCountry.ContainsKey(country))
                    townsByCountry[country].Add(town);
                else
                    townsByCountry[country] = new List<string>() { town };

                var population = decimal.Parse(cmdTokens[2]);
                populationByTown[town] = population;
            }

            foreach (var countryAndTown in townsByCountry)
            {
                Console.WriteLine("{0} -> {1}"
                    , countryAndTown.Key, countryAndTown.Value.Count);
            }

            var top3populations = populationByTown.OrderByDescending(p => p.Value).Take(3);
            foreach (var p in top3populations)
            {
                Console.WriteLine("{0} -> {1}"
                    , p.Key, p.Value);
            }
        }

        static string RemoveBadChars(string str)
        {
            var validCharsOnly = str.Split("@#$&01234567890".ToArray());
            var combined = string.Concat(validCharsOnly);
            return combined;
        }
    }
}
