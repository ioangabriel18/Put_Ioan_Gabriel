using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 42;
            int b = 119;
            int c = a + b;

            Console.WriteLine();
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = a + b = {0}", c);

            int R = 10;
            double pi = Math.PI;
            var S = pi * R * R;
            Console.WriteLine();
            Console.WriteLine("Raza cercului = {0}", R);
            Console.WriteLine("Aria cercului = {0}", S);

            Console.WriteLine("\n\nPress ENTER to exit...");
            Console.ReadLine();
        }
    }
}