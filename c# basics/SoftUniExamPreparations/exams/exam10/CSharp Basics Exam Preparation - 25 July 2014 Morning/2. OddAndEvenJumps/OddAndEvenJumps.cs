using System;
using System.Numerics;

class OddAndEvenJumps
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .ToLower()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        string processedInput = string.Join("", input);
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        long oddResult = 0;
        long evenResult = 0;
        int currentJumpPos = 1;
       
        // Odd characters
        for (int i = 0; i < processedInput.Length; i+=2)
        {
            long currentSymbolCode = (long)processedInput[i];
            if (currentJumpPos == oddJump)
            {
                oddResult *= currentSymbolCode;
                currentJumpPos = 1;
            }
            else 
            {
                oddResult += currentSymbolCode;
                currentJumpPos++;
            }
        }

        currentJumpPos = 1;
        // Even characters
        for (int i = 1; i < processedInput.Length; i += 2)
        {
            long currentSymbolCode = (long)processedInput[i];
            if (currentJumpPos == evenJump)
            {
                evenResult *= currentSymbolCode;
                currentJumpPos = 1;
            }
            else
            {
                evenResult += currentSymbolCode;
                currentJumpPos++;
            }
        }

        Console.WriteLine("Odd: {0:X}", oddResult);
        Console.WriteLine("Even: {0:X}", evenResult);
    }
}
