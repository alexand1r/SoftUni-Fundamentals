using System;

namespace _5.BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 6, 5, 3, 8 };
            BubbleSort1(arr);
        }

        static void BubbleSort1(int[] arr)
        {
            int temp;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j + 1] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Array.Reverse(arr);
            foreach (int num in arr)
            {
                Console.Write("{0} ", num);
            }

        }
    }
}
