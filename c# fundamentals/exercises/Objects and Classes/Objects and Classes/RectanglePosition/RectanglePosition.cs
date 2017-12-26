using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        int CalcArea()
        {
            return Width * Height;
        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
               (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }

    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle(), r2 = ReadRectangle();
            Console.WriteLine(r1.IsInside(r2) ? "Inside" :
              "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();
            Rectangle r = new Rectangle()
            { Left = input[0], Top = input[1]
            , Width = input[2], Height = input[3]};
            return r;
        }
    }
}
