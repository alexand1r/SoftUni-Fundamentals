using System;

namespace ChessboardGame
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
           
                int whiteScore = 0;
                int blackScore = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (i >= n * n)
                    {
                        break;
                    }
                    else if (i % 2 == 0 && char.IsUpper(input[i]))
                    {
                        whiteScore += input[i];
                    }
                    else if (i % 2 == 0 && char.IsLetterOrDigit(input[i]))
                    {
                        blackScore += input[i];
                    }
                    else if (i % 2 != 0 && char.IsUpper(input[i]))
                    {
                        blackScore += input[i];
                    }
                    else if (i % 2 != 0 && char.IsLetterOrDigit(input[i]))
                    {
                        whiteScore += input[i];
                    }
                }

                if (whiteScore == blackScore)
                {
                    Console.WriteLine("Equal result: {0}", whiteScore);
                }
                else
                {
                    Console.WriteLine("The winner is: {0}", whiteScore > blackScore ? "white team":"black team");
                    int difference = Math.Abs(whiteScore - blackScore);
                    Console.WriteLine(difference);
                }

         }
    }
}
