using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        class Message
        {
            public string Phase { get; set; }
            public string Event { get; set; }
            public string Author { get; set; }
            public string City { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Message[] messages = new Message[n];
            for (int i = 0; i < n; i++)
            {
                messages[i] = ReadMessage(); 
            }
            foreach (var message in messages)
            {
                Console.WriteLine("{0}. {1}. {2} - {3}"
                    , message.Phase, message.Event, message.Author, message.City);
            }
        }

        private static Message ReadMessage()
        {
            List<string> phases = new List<string>() { "Excellent product", "Such a great product", "I always use that product", "Best product of its category" };
            List<string> events = new List<string>() { "Now I feel good", "I have succeeded to change", "That makes miracles", "I cannot believe but now I feel awesome", "Try it yourself, I am very satisfied" };
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Misha" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            int phase = rnd.Next(phases.Count);
            int eventt = rnd.Next(events.Count);
            int author = rnd.Next(authors.Count);
            int city = rnd.Next(cities.Count);

            Message m = new Message()
            {
                Phase = phases[phase],
                Event = events[eventt],
                Author = authors[author],
                City = cities[city]
            };
            return m;
        }
    }
}
