using System;
using System.Text;

class ChangeEvenBits
{
    static void Main()
    {
        int helperNumbersCount = int.Parse(Console.ReadLine());
        int maxHelperNumber = int.MinValue;
        for (int i = 0; i < helperNumbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > maxHelperNumber)
            {
                maxHelperNumber = number;
            }
        }


        long numberToProcess = long.Parse(Console.ReadLine());
        StringBuilder numberAsString = new StringBuilder();
        numberAsString.Append(Convert.ToString(numberToProcess, 2));




        if (maxHelperNumber == int.MinValue)
        {
            Console.WriteLine(numberToProcess);
            Console.WriteLine(0);
            return;
        }

        string maxHelperNumberAsString = Convert.ToString(maxHelperNumber, 2);
        int maxBitCount = maxHelperNumberAsString.Length;

        int changedBits = 0;
        for (int position = 0; position < maxBitCount * 2; position += 2)
        {
            if (numberAsString[position] == '0')
            {
                numberAsString[position] = '1';
                changedBits++;
            }
            //if (GetBitAtPosition(numberToProcess, position) == 0)
            //{
            //    changedBits++;
            //    numberToProcess = SetBitToOne(numberToProcess, position);
            //}
        }

        Console.WriteLine(Convert.ToInt64(numberAsString.ToString(), 2));
        Console.WriteLine(changedBits);
    }

    static ulong GetBitAtPosition(ulong number, int position)
    {
        ulong nRightP = number >> position;
        ulong bit = nRightP & 1;
        return bit;
    }

    static ulong SetBitToZero(ulong number, int position)
    {
        ulong mask = (ulong)(~(1 << position));
        ulong result = number & mask;
        return result;
    }

    static ulong SetBitToOne(ulong number, int position)
    {
        ulong mask = (ulong)(1 << position);
        ulong result = number | mask;
        return result;
    }
}