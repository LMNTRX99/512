using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            a = 123456;
            b = 654321;
            c = 123654;
            double d;
            d = (a * 10 / 100 + b * 10 / 100 + c * 10 / 100) * 10 / 100;
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
