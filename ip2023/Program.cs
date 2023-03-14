using System;

namespace ip2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = 1;
            b = 1;
            c = -3;

            double delta = b * b - 4 * a * c;
            double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b + Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine("x = {0} lub x = {1}", x1, x2);

        }
    }
}
