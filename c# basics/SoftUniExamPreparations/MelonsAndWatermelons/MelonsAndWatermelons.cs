using System;

namespace MelonsAndWatermelons
{
    class MelonsAndWatermelons
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int melons = 0;
            int watermelons = 0;
            for (int i = dayOfWeek; i < dayOfWeek + days; i++)
            {
                switch (i % 7)
                {
                    case 1: watermelons++; break;
                    case 2: melons += 2; break;
                    case 3: watermelons++; melons++; break;
                    case 4: watermelons += 2; break;
                    case 5: watermelons += 2; melons += 2; break;
                    case 6: watermelons++; melons += 2; break;
                    default: break;
                }
            }

            int diff = Math.Abs(melons - watermelons);
            if (melons > watermelons)
            {
                Console.WriteLine("{0} more melons", diff);
            }
            else if (watermelons > melons)
            {
                Console.WriteLine("{0} more watermelons ", diff);
            }
            else
            {
                Console.WriteLine("Equal amount: {0}", melons);
            }
        }
    }
}
