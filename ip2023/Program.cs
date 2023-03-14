using System;

namespace ip2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Wprowadź współczynniki ax^2+bx+c");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("x = {0} lub x = {1}", x1, x2);
            } else
            {
                Console.WriteLine("brak rozwiązań");
            }
        }
    }
}
