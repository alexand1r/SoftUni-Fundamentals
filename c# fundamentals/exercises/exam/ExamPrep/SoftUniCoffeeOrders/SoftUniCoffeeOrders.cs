using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                //System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string datee = Console.ReadLine();
                DateTime orderDate = DateTime.ParseExact(datee, "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());
                int month = orderDate.Month;
                int year = orderDate.Year;

                int daysInMonth = DateTime.DaysInMonth(year, month);

                decimal num = daysInMonth * capsulesCount;
                decimal price = (decimal)num * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                sum += price;
            }

            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}

