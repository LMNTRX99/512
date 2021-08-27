using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 123456;
            double b = 245678;
            double c = 892135;
            double d = 423185;
            double e = 567890;
            double f = 325429;
            double k;
            k = a + b + c + d + e + f;
            double mn;
            mn = a * 1000000 + c;
            double hp;
            hp = ((k - mn) * 10 / 100 + e + f) * 11 / 100;
            Console.WriteLine(hp);
            Console.ReadKey();
        }
    }
}
