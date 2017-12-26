using System;

namespace TorrentPirate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int d = Int32.Parse(Console.ReadLine()); // download data
            int p = Int32.Parse(Console.ReadLine()); // price of cinema
            int w = Int32.Parse(Console.ReadLine()); // wife's spending

            double downloadTime = (double)d / 2 / 60 / 60;
            double priceDownload = downloadTime * w;
            double moviesDownload = (double)d / 1500;
            double priceCinema = moviesDownload * p;

            Console.WriteLine(priceDownload <= priceCinema ?
                "mall -> {0:0.00}lv" : "cinema -> {1:0.00}lv", priceDownload, priceCinema); 
        }
    }
}
