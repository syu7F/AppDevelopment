using System;

namespace TriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(2, 2);
            Point C = new Point(4, 0);

            Triangle triangle = new Triangle(A, B, C);

            triangle.print();

            Console.WriteLine("area: " + triangle.Area());
        }
    }
}