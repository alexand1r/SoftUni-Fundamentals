using System;
using System.Text;

namespace GameOfBits
{
    class GameOfBits
    {
        static void Main(string[] args)
        {
            uint inputNumber = uint.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            if(command != "GameOver!")
            {
                
                string printInputNumber = Convert.ToString(inputNumber, 2).PadLeft(8, '0');
                uint mask = 1;
                string printMask = Convert.ToString(mask, 2).PadLeft(8, '0');
                uint result = inputNumber & mask;
                uint result2;
                //string result = Convert.ToString(c, 2);

                Console.WriteLine(printInputNumber);
                Console.WriteLine(printMask);
                Console.Write(result);

                if (command == "Odd")
                {
                    while (inputNumber > 0)
                    {
                        inputNumber >>= 2;
                        result = inputNumber & mask;
                        //Console.Write(result);
                       
                    }
                    Console.WriteLine();
                    Console.WriteLine(sb.ToString());
                }
                int resultEven = Convert.ToInt32(sb.ToString());
                Console.WriteLine(resultEven);

                command = Console.ReadLine();

                
                resultEven >>= 1;
                uint mask2 = 2;
                string printMask2 = Convert.ToString(mask2, 2);
                uint result2 = resultEven & ;
                

                if (command == "Even")
                {
                    while (resultEven > 0)
                    {

                    }
                }
            }
        }
    }
}
