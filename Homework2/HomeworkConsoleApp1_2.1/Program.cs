using System;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 1234;
                int c = 0;
                while (a > 0)
                {
                    int b = a % 10;
                    c = c + b;
                    a = a / 10;
                    
                }
                Console.WriteLine(c);
            }

        }
    }
}
