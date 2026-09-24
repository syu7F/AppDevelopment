using System;

namespace TriangleApp
{
    internal class Triangle
    {
        private Point A;
        private Point B;
        private Point C;

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public void print()
        {
            Console.Write("A = ");
            A.Print();

            Console.Write("B = ");
            B.Print();

            Console.Write("C = ");
            C.Print();
        }

        public double Area()
        {
            return Math.Abs(
                A.x * (B.y - C.y) +
                B.x * (C.y - A.y) +
                C.x * (A.y - B.y)
            ) / 2.0;
        }
    }
}