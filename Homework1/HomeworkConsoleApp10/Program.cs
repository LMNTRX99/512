using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12345;
            double b = 56787;
            double c = 90418;
            double d = 67829;
            double e;
            e = (a + c) * (b + d) - c * 7 / 100;
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
