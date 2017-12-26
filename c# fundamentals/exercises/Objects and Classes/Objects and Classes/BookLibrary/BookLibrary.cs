using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class BookLibrary
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public string ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        class Library
        {
            public string Name { get; set; }
            public List<Book> Books{ get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library lb = new Library() { Name = "books", Books = new List<Book>()};
            for (int i = 0; i < n; i++)
            {
                lb.Books.Add(ReadBook());
            }
            var books = new SortedDictionary<string, decimal>();
            var authors = lb.Books.Select(s => s.Author).Distinct();
            foreach (string author in authors)
            {
                decimal priceByAuthor = lb.Books.Where(b => b.Author.Equals(author))
                    .Select(s => s.Price).Sum();
                books[author] = priceByAuthor;
            }
            books.Keys.OrderBy(b => b)
                .OrderBy(x => -books[x])
                .ToList()
                .ForEach(b => Console.WriteLine("{0} -> {1:f2}"
                                               , b, books[b]));
        }

        private static Book ReadBook()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Book b = new Book()
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = input[3],
                ISBN = input[4],
                Price = decimal.Parse(input[5])
            };

            return b;
        }
    }
}
