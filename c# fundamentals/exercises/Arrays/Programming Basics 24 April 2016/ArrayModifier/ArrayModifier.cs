using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            BigInteger[] nums = Console.ReadLine().Split(' ')
                .Select(BigInteger.Parse).ToArray();

            string str = Console.ReadLine();
            while(!str.Equals("end"))
            {
                string[] tokens = str.Split(' ');
                string command = tokens[0];
                int elem1 = 0, elem2 = 0;
                if (tokens.Length > 1)
                {
                    elem1 = int.Parse(tokens[1]);
                    elem2 = int.Parse(tokens[2]);
                }

                switch (command)
                {
                    case "swap":
                        SwapElements(nums, elem1, elem2);
                        break;
                    case "multiply":
                        MultiplyElements(nums, elem1, elem2);
                        break;
                    case "decrease":
                        DecreaseElements(nums);
                        break;
                    default: break;
                }

                str = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", nums));
        }

        private static void DecreaseElements(BigInteger[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]--;
            }
        }

        private static void MultiplyElements(BigInteger[] nums, int elem1, int elem2)
        {
            nums[elem1] = nums[elem1] * nums[elem2];
        }

        private static void SwapElements(BigInteger[] nums, int elem1, int elem2)
        {
            BigInteger temp = nums[elem1];
            nums[elem1] = nums[elem2];
            nums[elem2] = temp;
        }
    }
}
