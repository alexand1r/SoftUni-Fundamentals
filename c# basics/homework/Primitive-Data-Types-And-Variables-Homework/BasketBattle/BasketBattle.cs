using System;

namespace BasketBattle
{
    class BasketBattle
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            int rounds = int.Parse(Console.ReadLine());
            bool firstSimeon = false;
            bool firstNakov = false;
            int sPoints = 0;
            int nPoints = 0;
            string winner = "";
            int winningRound = 0;

            if (firstPlayer == "Simeon")
            {
                firstSimeon = true;
            }
            else if (firstPlayer == "Nakov")
            {
                firstNakov = true;
            }

            for (int round = 1; round <= rounds; round++)
            {
                int firstPoints = int.Parse(Console.ReadLine());
                string firstShot = Console.ReadLine();

                if (firstSimeon)
                {
                    if (firstShot == "success" && sPoints + firstPoints <= 500)
                    {
                        sPoints += firstPoints;
                    }
                    if (sPoints == 500)
                    {
                        winner = "Simeon";
                        winningRound = round;
                        break;
                    }

                    int secondPoints = int.Parse(Console.ReadLine());
                    string secondShot = Console.ReadLine();

                    if (secondShot == "success" && nPoints + secondPoints <= 500)
                    {
                        nPoints += secondPoints;
                        if (nPoints == 500)
                        {
                            winner = "Nakov";
                            winningRound = round;
                            break;
                        }
                    }
                }

                if (firstNakov)
                {
                    if (firstShot == "success" && nPoints + firstPoints <= 500)
                    {
                        nPoints += firstPoints;
                    }

                    if (nPoints == 500)
                    {
                        winner = "Nakov";
                        winningRound = round;
                        break;
                    }

                    int secondPoints = int.Parse(Console.ReadLine());
                    string secondShot = Console.ReadLine();

                    if (secondShot == "success" && sPoints + secondPoints <= 500)
                    {
                        sPoints += secondPoints;
                        if (sPoints == 500)
                        {
                            winner = "Simeon";
                            winningRound = round;
                            break;
                        }
                    }
                }

                firstSimeon = !firstSimeon;
                firstNakov = !firstNakov;
            }


            if (winner == "Simeon")
            {
                Console.WriteLine("\n" + winner);
                Console.WriteLine(winningRound);
                Console.WriteLine(nPoints);
            }
            else if (winner == "Nakov")
            {
                Console.WriteLine("\n" + winner);
                Console.WriteLine(winningRound);
                Console.WriteLine(sPoints);
            }
            else if (winner == "" && sPoints == nPoints)
            {
                Console.WriteLine("\nDRAW");
                Console.WriteLine(sPoints);
            }
            else
            {
                if (sPoints > nPoints)
                {
                    Console.WriteLine("\nSimeon");
                    Console.WriteLine(sPoints - nPoints);
                }
                else
                {
                    Console.WriteLine("\nNakov");
                    Console.WriteLine(nPoints - sPoints);
                }
            }
        }
    }
}
    

