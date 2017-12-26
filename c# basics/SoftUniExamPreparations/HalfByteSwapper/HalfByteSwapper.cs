using System;

namespace HalfByteSwapper
{
    class HalfByteSwapper
    {
        static void Main(string[] args)
        {
            uint[] nums = new uint[4];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = uint.Parse(Console.ReadLine());
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split();
                int[] line1 = Array.ConvertAll(input, int.Parse);
                int firstNumber = line1[0];
                int firstColumn = line1[1] * 4;
                input = Console.ReadLine().Split();
                int[] line2 = Array.ConvertAll(input, int.Parse);
                int secondNumber = line2[0];
                int secondColumn = line2[1] * 4;

                uint firstMask = 15u << firstColumn;
                uint secondMask = 15u << secondColumn;
                uint switch1 = (nums[firstNumber] & firstMask) >> firstColumn;
                uint switch2 = (nums[secondNumber] & secondMask) >> secondColumn;

                nums[firstNumber] &= ~firstMask;
                nums[secondNumber] &= ~secondMask;

                nums[firstNumber] |= switch2 << firstColumn;
                nums[secondNumber] |= switch1 << secondColumn;

                command = Console.ReadLine();
            }
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
