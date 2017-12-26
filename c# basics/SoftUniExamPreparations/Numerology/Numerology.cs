using System;

namespace Numerology
{
    class Numerology
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('.', ' ');
            int day = int.Parse(input[0]);
            int month = int.Parse(input[1]);
            int year = int.Parse(input[2]);
            string username = input[3];

            long result = day * month * year;

            if (month % 2 == 1)
            {
                result *= result;
            }

            for (int i = 0; i < username.Length; i++)
            {
                if (username[i] >= 'a' && username[i] <= 'z')
                {
                    result += username[i] - 96;
                }
                else if (username[i] >= 'A' && username[i] <= 'Z')
                {
                    result += (username[i] - 64) * 2;
                }
                else if (username[i] >= '0' && username[i] <= '9')
                {
                    result += username[i] - '0';
                }
            }
            while (result > 13)
            {
                result = CheckCelestial(result);
            }
            Console.WriteLine(result);
        }

        public static long CheckCelestial(long celestial)
        {
            long sum = 0;
            while (celestial != 0)
            {
                sum += celestial % 10;
                celestial /= 10;
            }
            celestial = sum;
            return celestial;
        }
    }
}
