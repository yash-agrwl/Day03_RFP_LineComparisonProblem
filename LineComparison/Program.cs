using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program.\n");

            Line Line1 = new();

            Line1.input("Line1");

            Console.WriteLine("The Lenght of Line1 is: " + Line1.CalculateLength() + " units");
        }
    }
}
