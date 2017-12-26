using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PopulationAggregation
{
    class PopulationAggregation
    {
        static void Main(string[] args)
        {
            var countries = ReadCitiesAndCountries();
            countries.OrderBy(c => c.Key).ToList()
                .ForEach(x => Console.WriteLine("{0} -> {1}"
                , x.Key, countries[x.Key].Keys.Count));
            var cities = new SortedDictionary<string, BigInteger>();
            foreach (var country in countries)
            {
                List<string> citiez = country.Value.Keys.ToList();
                foreach (var city in citiez)
                {
                    cities.Add(city, country.Value[city]);
                }
            }
            cities.OrderByDescending(s => s.Value).Take(3)
                .ToList().ForEach(x =>
                Console.WriteLine("{0} -> {1}", x.Key, x.Value));
        }

        private static Dictionary<string, Dictionary<string, BigInteger>> ReadCitiesAndCountries()
        {
            string input = Console.ReadLine();
            var countries = new Dictionary<string, Dictionary<string, BigInteger>>();
            while (!input.Equals("stop"))
            {
                char[] separators = "@#$&0123456789".ToCharArray();
                string[] tokens = input
                    .Split(new char[] { '\\' }
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] arr1 = tokens[0].Split(separators
                    , StringSplitOptions.RemoveEmptyEntries);
                tokens[0] = string.Join("", arr1);
                string[] arr2 = tokens[1].Split(separators
                    , StringSplitOptions.RemoveEmptyEntries);
                tokens[1] = string.Join("", arr2);
                string country = string.Empty;
                string city = string.Empty;
                BigInteger population = BigInteger.Parse(tokens[2]);

                if (Char.IsUpper(tokens[0].First()))
                {
                    country = tokens[0];
                    city = tokens[1];
                }
                else
                {
                    country = tokens[1];
                    city = tokens[0];
                }
                
                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, BigInteger>());
                }
                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, population);
                }
                else
                {
                    countries[country].Add(city, population);
                }

                input = Console.ReadLine();
            }
            return countries;
        }
    }
}
