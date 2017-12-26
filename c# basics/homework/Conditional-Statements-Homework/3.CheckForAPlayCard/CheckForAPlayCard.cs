using System;

namespace _3.CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();

            switch (card)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "K":
                case "Q":
                case "A": Console.WriteLine("Yes"); break;
                default: Console.WriteLine("No"); break;                        
            }
        }
    }
}
