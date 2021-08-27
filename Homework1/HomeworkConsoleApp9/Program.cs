using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=1234;
            double b=4321;
            double c=1243;
            double d;
                   d = a * 1 / 100 - b * 2 / 100 - c * 3 / 100;
            double k;
                   k = d + c * 7 / 100;
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
