using System;

namespace TheBetterMusicProducer
{
    class TheBetterMusicProducer
    {
        static void Main(string[] args)
        {
            decimal albumsEurope = decimal.Parse(Console.ReadLine());
            decimal priceEurope = decimal.Parse(Console.ReadLine()) * 1.94M;
            decimal albumsNorthAmerica = decimal.Parse(Console.ReadLine());
            decimal priceNorthAmerica = decimal.Parse(Console.ReadLine()) * 1.72M;
            decimal albumsSouthAmerica = decimal.Parse(Console.ReadLine());
            decimal priceSouthAmerica = decimal.Parse(Console.ReadLine()) / 332.74M;
            decimal concerts = decimal.Parse(Console.ReadLine());
            decimal priceConcert = decimal.Parse(Console.ReadLine()) * 1.94M;

            decimal totalPriceAlbums = albumsEurope * priceEurope + albumsNorthAmerica * priceNorthAmerica + albumsSouthAmerica * priceSouthAmerica;
            decimal totalPriceConcerts = concerts * priceConcert;
             
            totalPriceAlbums -= 35M * totalPriceAlbums / 100;
            totalPriceAlbums -= 20M * totalPriceAlbums / 100;
            if (totalPriceConcerts > 100000)
            {
                totalPriceConcerts -= 15M * totalPriceConcerts / 100;
            }

            if (totalPriceAlbums > totalPriceConcerts)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:0.00}lv.", totalPriceAlbums);
            }
            else if (totalPriceAlbums <= totalPriceConcerts)
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:0.00}lv.", totalPriceConcerts);
            }
        }
    }
}
