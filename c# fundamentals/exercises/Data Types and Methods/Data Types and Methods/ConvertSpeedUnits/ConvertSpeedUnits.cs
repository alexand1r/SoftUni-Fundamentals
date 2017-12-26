using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine()) * 3600;
            int minutes = int.Parse(Console.ReadLine()) * 60;
            int seconds = int.Parse(Console.ReadLine());
            int totalSeconds = hours + minutes + seconds;
            float finalHours = totalSeconds / 3600f;
            float miles = meters / 1609f;
            float kil = meters / 1000f;
            Console.WriteLine((float)meters / totalSeconds);
            Console.WriteLine(kil / finalHours);
            Console.WriteLine(miles / finalHours);
        }
    }
}
