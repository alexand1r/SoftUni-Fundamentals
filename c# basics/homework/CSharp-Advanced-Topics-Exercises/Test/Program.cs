using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Methods.Divide(5, 0));
            // Methods.PrintMatrix(5);

            // int a = -5;
            // Console.WriteLine(Math.Abs(a));
            // Console.WriteLine(Math.Ceiling(3.2));
            // Console.WriteLine(Math.E);
            // Console.WriteLine(Math.PI);

            // Console.WriteLine(DateTime.Today);
            // Console.WriteLine(DateTime.UtcNow);

            // Console.WriteLine("   pesho   ".Trim() + "soome");

            //int[][]a = new int[5][];

            //var matrix = Methods.CreateMatrix(4);
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            // int[] arr = { 4, 5, 2, 612, 3, 7, 9, 52, 6, 34 };
            // // Array.Sort(arr);
            // var a = Array.FindAll(arr, t => t % 2 == 0);
            //// Console.WriteLine(a);
            //// themikuma
            //// SoftUniRuse2015
            // foreach (var item in a)
            // {
            //     Console.Write("{0} ", item);
            // }

            // Console.WriteLine();
            //Methods.Reorder(arr);

            //foreach (var item in arr)
            //{
            //    Console.Write("{0} ", item);
            //}

            //List<int> pesho = new List<int>();
            //pesho.Add(5);
            //pesho.Add(0);
            //pesho.Add(6);
            //pesho.Add(2);
            //pesho.Add(8);
            //pesho.Add(16);
            //pesho.Remove(6); // !!! , Insert, RemoveAt

            //var kolio = pesho.FindAll(t => t % 4 == 0);
            //foreach (var item in kolio)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine();
            //Console.WriteLine(pesho[2]);

            //List<string> names = new List<string>() {
            //    "gosho", "tosho", "pesho", "nikolai", "pesho" };
            //Console.WriteLine(names.LastIndexOf("pesho"));

            // dictionary // name.trygetvalue(..., out "not found"); // name.keys;

            //string str = "SoftUni";
            //Console.WriteLine(str.IndexOf("Uni"));
            //Console.WriteLine(str.Substring(4, 3)); // Uni
            //Console.WriteLine(str.Replace("Soft", "Hard")); // HardUni

            //          string allLangs = "C#, Java; HTML, CSS; PHP, SQL";
            //          string[] langs = allLangs.Split(new char[] { ',', ';', ' ' },
            //StringSplitOptions.RemoveEmptyEntries);
            //          foreach (var lang in langs)
            //              Console.WriteLine(lang);
            //          Console.WriteLine("Langs = " + string.Join(", ", langs));
            //          Console.WriteLine("  \n\n Software  University  ".Trim());

            //Point a = new Point();
            //a.X = 5;
            //a.Y = 3;
            //Point b = new Point() { X = 5, Y = 3 };
            //Point c = new Point() { X = 4, Y = 2 };
            //Point d = new Point() { X = 3, Y = 4 };
            //Point e = new Point() { X = 2, Y = 6 };
            //Point[] line = { a, b, c, d, e };


        }

        //public class Square
        //{
        //    public Point UpperLeftVertex { get; }
        //    public int Side { get; }
        //    public Square(int upperLeftVertex, int side)
        //    {
        //        this.UpperLeftVertex = upperLeftVertex;
        //        this.Side = side;
        //    }
        //}

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
