using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12345;
            double b = 23451;
            double c = 43215;
            double d = 321;
            double e = 123;
            double km;
            km = a * 5 / 100 * b * 5 / 100 * c * 5 / 100;
            double mn;
            mn = d * 3 / 100 + e * 3 / 100;
            double bu;
            bu = km * 10 / 100 + mn * 10 / 100;
            Console.WriteLine(bu);
            Console.ReadKey();        
        }
    }
}
