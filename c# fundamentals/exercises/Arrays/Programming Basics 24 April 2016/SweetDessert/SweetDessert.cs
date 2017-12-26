using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            int sets = guests / 6;
            if (guests % 6 != 0) sets++;

            decimal neededMoney =
                (decimal)sets * (2m * bananaPrice + 4m * eggsPrice + 0.2m * berriesPrice);

            if (neededMoney > money)
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more."
                    , neededMoney - money);
            }
            else
            {
               Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv."
                   , neededMoney);
            }
        }
    }
}
