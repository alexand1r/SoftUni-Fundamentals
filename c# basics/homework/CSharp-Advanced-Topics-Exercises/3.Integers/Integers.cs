using System;

namespace _3.Integers
{
    class Integers
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 9);
            }

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                Console.Write("{0} ", arr[i] + arr[i - 1]);
            }
            Console.WriteLine();
        }
    }
}
