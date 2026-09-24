using System;

namespace TriangleApp
{
    internal class Point
    {
        public int x;
        public int y;

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine($"({x}, {y})");
        }
    }
}