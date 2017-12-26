using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class VehiclePark
    {
        static void Main(string[] args)
        {
            List<string> vehicles = Console.ReadLine()
                .Split(' ').ToList();

            int soldVehiclesCount = 0;
            string command = Console.ReadLine();
            while (!command.Equals("End of customers!"))
            {
                string[] tokens = command.Split(' ');
                string str = tokens[0].ToLower();
                char vehicle = str[0];
                int seats = int.Parse(tokens[2]);
                string match = "" + vehicle + seats;

                bool found = false;
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].Equals(match))
                    {
                        soldVehiclesCount++;
                        vehicles.RemoveAt(i);
                        if (i > 0) i--;
                        long price = (int)vehicle * seats;
                        Console.WriteLine("Yes, sold for {0}$", price);
                        found = true;
                        break;
                    }
                }

                if (!found) Console.WriteLine("No");

                command = Console.ReadLine();
            }

            Console.WriteLine("Vehicles left: {0}", string.Join(", ", vehicles));
            Console.WriteLine("Vehicles sold: {0}", soldVehiclesCount);
        }
    }
}
