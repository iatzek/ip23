using System;

namespace ip2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("ax^2+bx+c");
            Console.WriteLine("Input a");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Input b");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Input c");
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / 2 / a;

                Console.WriteLine("x = {0} / x = {1}", x1, x2);
            } 
            else if (delta == 0)
            {
                double x = (-b ) / 2 / a;
                Console.WriteLine("x = {0}", x);
            }
            
            else
            {
                Console.WriteLine("brak rozwiązań");
            }
        }
    }
}
