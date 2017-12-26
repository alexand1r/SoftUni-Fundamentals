using System;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();
            int twoPower = 1;
            long decimalNum = 0;
            for (int i = binaryNum.Length - 1; i >= 0; i--)
            {
                if (binaryNum[i] == '1')
                {
                    decimalNum += twoPower;
                }
                twoPower <<= 1;
            }
            Console.WriteLine(decimalNum);
        }
    }
}
