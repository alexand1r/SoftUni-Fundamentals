using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class SalesReport
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach (var town in towns)
            {
                var salesByTown = sales.Where(s => s.Town == town)
                  .Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }
        }

        static Sale ReadSale()
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }

        static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }
}
