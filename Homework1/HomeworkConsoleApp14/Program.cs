using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 123;
            double b = 321;
            double t = 1234;
            double c = 4321;
            double d = 12345;
            double e = 54321;
            double f = 123456;
            double k;
            k = a + b + t * c;
            double m;
            m = k * 10 + 7 + d + e;
            double n;
            n = m - a * b - 1 + f - a - b - c - t;
            double v;
            v = n * 18 / 100 * 3 / 100 * 1 / 100 + d + e;
            Console.WriteLine(v);
            Console.ReadKey();
            
        }
    }
}
