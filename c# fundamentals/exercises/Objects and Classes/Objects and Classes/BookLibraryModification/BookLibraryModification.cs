using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class BookLibraryModification
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library lb = new Library() { Name = "lib", Books = new List<Book>()};
            for (int i = 0; i < n; i++)
            {
                lb.Books.Add(ReadBook());
            }
            DateTime afterDate = 
                DateTime.ParseExact(Console.ReadLine()
                , "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<Book> result = new List<Book>();
            foreach (var book in lb.Books)
            {
                if (book.ReleaseDate > afterDate)
                {
                    result.Add(book);
                }
            }
            result.OrderBy(title => title.Title)
                .OrderBy(date => date.ReleaseDate)
                .ToList().ForEach(x => Console.WriteLine("{0} -> {1:d.MM.yyyy}"
                                                        , x.Title, x.ReleaseDate));
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
                ReleaseDate = DateTime
                .ParseExact(input[3],"d.MM.yyyy"
                , CultureInfo.InvariantCulture),
                ISBN = input[4],
                Price = decimal.Parse(input[5])
            };

            return b;
        }
    }
}
