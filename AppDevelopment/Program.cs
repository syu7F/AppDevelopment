using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static int Add(int x, int count = 2)
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum = sum + x;
            }

            return sum;
        }

        static double Add(double x, int count = 2)
        {
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum = sum + x;
            }

            return sum;
        }

        static string Add(string x, int count = 2)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += x;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string z = Console.ReadLine();

            Console.WriteLine(Add(x, 3));
            Console.WriteLine(Add(y, 4));
            Console.WriteLine(Add(z, 3));

            Random r = new Random();
            int n = r.Next(1, 101);

            Console.WriteLine(n);
        }
    }
}