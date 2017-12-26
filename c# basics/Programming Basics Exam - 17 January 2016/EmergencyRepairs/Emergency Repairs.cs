using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EmergencyRepairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong wall = ulong.Parse(Console.ReadLine());
            ulong result = 0;
            //Console.WriteLine(Convert.ToString((long)wall, 2).PadLeft(63, '0'));
            int kits = int.Parse(Console.ReadLine());
            int attacks = int.Parse(Console.ReadLine());
            for (short i = 0; i < attacks; i++)
            {
                int attack = int.Parse(Console.ReadLine());
                for (int bit = 0; bit < 63; bit++)
                {
                    ulong checkBit = (wall >> bit) & 1;
                    if (checkBit == 1 && bit == attack)
                    {
                        wall &= ~(1UL << bit); 
                    }
                }
            }
            //Console.WriteLine(Convert.ToString((long)wall, 2).PadLeft(63, '0'));
            
            for (int bit = 0; bit < 64; bit++)
            {
                ulong currentBit = (wall >> bit) & 1;
                
                bool hasRight = bit > 0;
                int previousBit = (bit - 1);
                ulong bitCheckRight = (wall >> previousBit) & 1;
                bool isZeroRight = bitCheckRight == 0;
                bool rightFinal = isZeroRight && hasRight;
                    
                bool hasLeft = bit < 63;
                int nextBit = (bit + 1);
                ulong bitCheckLeft = (wall >> nextBit) & 1;
                bool isZeroLeft = bitCheckLeft == 0;
                bool leftFinal = isZeroLeft && hasLeft;

                bool hasNeighbour = leftFinal | rightFinal;

                if (currentBit == 0 && kits > 0 && hasNeighbour)
                {
                    result >>= 1;
                    result |= 1UL << 63;
                    kits--;
                }
                else
                {
                    result >>= 1;
                    result |= currentBit << 63;
                }
                
            }

            Console.WriteLine(result);
           // Console.WriteLine(Convert.ToString((long)result, 2).PadLeft(63, '0'));
        }
    }
}
