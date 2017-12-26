using System;

namespace ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            uint b = uint.Parse(Console.ReadLine());
            uint r = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());
            uint t = uint.Parse(Console.ReadLine());
            uint o = uint.Parse(Console.ReadLine());
            decimal n = decimal.Parse(Console.ReadLine());
            decimal u = decimal.Parse(Console.ReadLine());
            decimal s = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal bSalary = b * 1500.04m;
            decimal rSalary = r * 2102.10m;
            decimal cSalary = c * 1465.46m;
            decimal tSalary = t * 2053.33m;
            decimal oSalary = o * 3010.98m;
            decimal nSalary = n * u;
            decimal totalMoneyNeeded = bSalary + rSalary + cSalary
                + tSalary + oSalary + nSalary + s;
            Console.WriteLine("The amount is: {0:F2} lv.", totalMoneyNeeded);
            if (m >= totalMoneyNeeded)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", m - totalMoneyNeeded);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", totalMoneyNeeded - m);
            }
            //Console.WriteLine("{0} \\ {1}: {2:f2} lv.",
            //totalExpences <= m ? "YES" : "NO",
            //totalExpences <= m ? "Left" : "Need more",
            //Math.Abs(m - totalExpences));
        }
    }
}
