using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program.\n");

            Line Line1 = new();
            Line Line2 = new();

            Line1.Input("Line1");
            Line2.Input("Line2");

            Console.WriteLine("The Lenght of Line1 is: " + Line1.CalculateLength() + " units");
            Console.WriteLine("The Lenght of Line2 is: " + Line2.CalculateLength() + " units");

            Line.Compare(Line1.Length,Line2.Length);
        }
    }
}
