using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Line
    {

        public double Length;
        double[] x = new double[2], y = new double[2];

        public double CalculateLength()
        {
            Length = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));
            Length = Math.Round(Length, 2);
            return Length;
        }

        public static void Compare(double length1, double length2)
        {
            int lengthCheck = length1.CompareTo(length2);
            if (lengthCheck == 0)
                Console.WriteLine("\nThe Two Lines Are Of Equal Lengths");
            else if (lengthCheck == 1)
                Console.WriteLine("\nLength Of Line1 Is Greater Than Line2");
            else
                Console.WriteLine("\nLength Of Line2 Is Greater Than Line1");
        }

        public void Input(string lineName)
        {
            Console.WriteLine("Enter the co-ordinates for " + lineName);
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter x[" + i + "]: ");
                x[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter y[" + i + "]: ");
                y[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }
    }
}
