namespace Arrays
{
    using System;
    using System.Linq;

    public class ArrayTest
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] line = command.Split(ArgumentsDelimiter);
                int[] args = new int[2];

                if (line.Length > 1)
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);
                }

                PerformAction(array, line[0], args);

                PrintArray(array);

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long pos = args[0];
            long value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos - 1] *= value;
                    break;
                case "add":
                    arr[pos - 1] += value;
                    break;
                case "subtract":
                    arr[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
