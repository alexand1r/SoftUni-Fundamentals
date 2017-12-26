using System;

namespace BookOrders
{
    class BookOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int allBoughtBooks = 0;
            double finalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int books = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());

                int allBooks = packets * books;
                allBoughtBooks += allBooks;

                double discount = 0;
                if (packets >= 10 && packets < 110)
                {
                    discount = (packets / 10) + 4; 
                }
                else if (packets >= 110)
                {
                    discount = 15;
                }

                double priceWithDiscount = price * (100 - discount) / 100;
                finalPrice += priceWithDiscount * allBooks;
            }

            Console.WriteLine(allBoughtBooks);
            Console.WriteLine("{0:F2}", finalPrice);
        }
    }
}
