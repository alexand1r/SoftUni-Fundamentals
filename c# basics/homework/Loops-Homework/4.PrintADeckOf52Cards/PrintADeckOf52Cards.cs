using System;
using System.Text;

namespace _4.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] cards = new string[] {
                "2", "3", "4", "5", "6", "7",
                "8", "9", "10", "J", "Q", "K", "A"};
            char[] paint = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 0; i <= cards.Length -1; i++) {
                for (int j = 0; j <= paint.Length -1; j++)
                {
                    Console.Write("{0,3}{1} ", cards[i], paint[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
