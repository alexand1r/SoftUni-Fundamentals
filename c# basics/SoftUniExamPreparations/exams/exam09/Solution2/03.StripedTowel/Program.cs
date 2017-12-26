using System;

class Program
{
    static void Main()
    {
        //int width = int.Parse(Console.ReadLine());
        //int height = (int)Math.Floor(width * 1.5D);

        //string outputString = "";
        //for (int i = 0; i < Math.Ceiling((width * height) / 3.0); i++)
        //{
        //    outputString += "#..";
        //}

        //for (int row = 0; row < height; row++)
        //{
        //    string stringToPrint = outputString.Substring(row * width, width);
        //    Console.WriteLine(stringToPrint);
        //}

        //int width = int.Parse(Console.ReadLine());
        //int height = (int)Math.Floor(width * 1.5D);

        //string template = "";
        //for (int i = 0; i < (width / 2) + 1; i++)
        //{
        //    template += "#..";
        //}

        //for (int i = 0; i < (height - 1) / 3; i++)
        //{
        //    for (int row = 0; row < 3; row++)
        //    {
        //        string stringToPrint = template.Substring(row, width);
        //        Console.WriteLine(stringToPrint);
        //    }
        //}

        //string lastRow = template.Substring(0, width);
        //Console.WriteLine(lastRow);

        int width = int.Parse(Console.ReadLine());
        int height = (int)Math.Floor(width * 1.5);

        int totalSymbolsCount = width * height;
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((row + col) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();
        }
    }
}

