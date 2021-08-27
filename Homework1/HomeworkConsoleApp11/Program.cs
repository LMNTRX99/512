using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 123456;
            double b = 234567;
            double c = 345678;
            double d = 456789;
            double e;
            e = a * 10 / 100 + b * 10 / 100 + c * 10 / 100 + d * 10 / 100;
            double h;
            h = a * 15 / 100 + b * 15 / 100 + c * 15 / 100 + d * 15 / 100;
            double g;
            g = e * h;
            double t;
            t = g * 10 / 100;
            double k;
            k = t * 11 / 100;
            Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}
