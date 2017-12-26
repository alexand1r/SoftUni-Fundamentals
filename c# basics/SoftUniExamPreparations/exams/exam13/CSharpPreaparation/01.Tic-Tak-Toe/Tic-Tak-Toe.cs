using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tic_Tak_Toe
{
    class Tic_Tak_Toe
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int position = 0;

            if (y == 0&&x == 0) { position = 1; }
            if (y == 0&&x == 1) { position = 2; }
            if (y == 0&&x == 2) { position = 3; }
            if (y == 1&&x == 0) { position = 4; }
            if (y == 1&&x == 1) { position = 5; }
            if (y == 1&&x == 2) { position = 6; }
            if (y == 2&&x == 0) { position = 7; }
            if (y == 2&&x == 1) { position = 8; }
            if (y == 2&&x == 2) { position = 9; }
            
            //position = 3 * x + y;

            Console.WriteLine((long)Math.Pow(value + position - 1, position));
        }
    }
}
