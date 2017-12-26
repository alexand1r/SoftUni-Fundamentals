using System;
using System.Linq;

class NakovsMatching
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int maxWeight = int.Parse(Console.ReadLine());

        bool resultFound = false;

        for (int firstDivider = 1; firstDivider < firstWord.Length; firstDivider++)
        {
            for (int secondDivider = 1; secondDivider < secondWord.Length; secondDivider++)
            {
                string firstLeft = firstWord.Substring(0, firstDivider);
                string firstRight = firstWord.Substring(firstDivider);
                string secondLeft = secondWord.Substring(0, secondDivider);
                string secondRight = secondWord.Substring(secondDivider);
                //Console.Write("{0}|{1}", firstLeft, firstRight);
                //Console.WriteLine("      {0}|{1}", secondLeft, secondRight);

                long firstLeftWeight = CalculateWeight(firstLeft);
                long firstRightWeight = CalculateWeight(firstRight);
                long secondLeftWeight = CalculateWeight(secondLeft);
                long secondRightWeight = CalculateWeight(secondRight);
                //Console.Write("{0}|{1}", firstLeftWeight, firstRightWeight);
                //Console.WriteLine("      {0}|{1}", secondLeftWeight, secondRightWeight);

                long nakovWeight = Math.Abs(
                    firstLeftWeight * secondRightWeight - secondLeftWeight * firstRightWeight);
                if (nakovWeight <= maxWeight)
                {
                    resultFound = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                        firstLeft, firstRight, secondLeft, secondRight, nakovWeight);
                }
            }
        }

        if (!resultFound)
        {
            Console.WriteLine("No");
        }
    }

    static long CalculateWeight(string word)
    {
        long sum = 0;
        for (int i = 0; i < word.Length; i++)
        {
            sum += (int)word[i];
        }

        return sum;
    }
}
