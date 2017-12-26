using System;
using System.Text;

namespace GameOfBits
{
    class GameOfBits
    {
        static void Main(string[] args)
        {
            uint inputNumber = uint.Parse(Console.ReadLine());
            uint newNum = inputNumber;

            string command = Console.ReadLine();
            while (command != "Game Over!")
            {
                if (command == "Even")
                {
                    inputNumber >>= 1;
                }

                newNum = extractBits(newNum, inputNumber);
                inputNumber = newNum;
                command = Console.ReadLine();
            }

            int bitsOne = 0;
            while (newNum > 0)
            {
                uint bit = newNum & 1;
                if(bit == 1)
                {
                    bitsOne++;
                }
                newNum >>= 1;
            }

            Console.WriteLine("{0} -> {1}", inputNumber, bitsOne);

        }
        private static uint extractBits(uint newNum, uint inputNumber)
        {
            newNum = inputNumber & 1;
            inputNumber >>= 2;
            int count = 1;
            uint move = 0;
            while (inputNumber > 0)
            {
                move = (inputNumber & 1) << count;
                newNum |= move;
                inputNumber >>= 2;
                count++;
            }
            return newNum;
        }
                               
    }
}