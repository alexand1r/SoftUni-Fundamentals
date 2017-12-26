using System;
using System.Linq;

namespace LightTheTorches
{
    class LightTheTorches
    {
        static void Main(string[] args)
        {
            int totalNumberOfRooms = int.Parse(Console.ReadLine());
            char[] arr = new char[totalNumberOfRooms];


            string lights = Console.ReadLine();
            char[] lightsArr = lights.ToCharArray();


            //fill the array with the information about which lights are lit
            int lightsCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = lightsArr[lightsCounter];
                lightsCounter++;
                if (lightsCounter > lightsArr.Length - 1)
                {
                    lightsCounter = 0;
                }
            }


            string commandsForThePriest = String.Empty;
            int steps;
            int currentPosition = totalNumberOfRooms / 2;
            int lastPosition;
            while (true)
            {
                commandsForThePriest = Console.ReadLine();

                if (commandsForThePriest == "END")
                {
                    break;
                }

                steps = int.Parse(commandsForThePriest.Split(' ')[1]) + 1;

                if (commandsForThePriest.First() == 'R')
                {
                    if (currentPosition + steps < arr.Length - 1)
                    {
                        lastPosition = currentPosition;
                        currentPosition = currentPosition + steps;
                        if (currentPosition != lastPosition)
                        {
                            arr[currentPosition] = changeLights(arr[currentPosition]);
                        }
                    }
                    else if (currentPosition + steps >= arr.Length - 1)
                    {
                        lastPosition = currentPosition;
                        currentPosition = arr.Length - 1;
                        if (currentPosition != lastPosition)
                        {
                            arr[currentPosition] = changeLights(arr[currentPosition]);
                        }

                    }
                }
                else if (commandsForThePriest.First() == 'L')
                {
                    if (currentPosition - steps > 0)
                    {
                        lastPosition = currentPosition;
                        currentPosition = currentPosition - steps;
                        if (currentPosition != lastPosition)
                        {
                            arr[currentPosition] = changeLights(arr[currentPosition]);
                        }

                    }
                    else if (currentPosition - steps <= 0)
                    {
                        lastPosition = currentPosition;
                        currentPosition = 0;
                        if (currentPosition != lastPosition)
                        {
                            arr[currentPosition] = changeLights(arr[currentPosition]);
                        }

                    }
                }

            }

            int counterOfPrayers = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'D')
                {
                    counterOfPrayers++;
                }
            }
            int multiplier = 'D';


            Console.WriteLine(counterOfPrayers * multiplier);
        }
        public static char changeLights(char c)
        {
            if (c == 'D')
            {
                c = 'L';
            }
            else if (c == 'L')
            {
                c = 'D';
            }
            return c;
        }
    }
}
