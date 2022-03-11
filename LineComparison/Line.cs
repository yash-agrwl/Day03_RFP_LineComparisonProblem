using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Line
    {
        double length;
        double[] x = new double[2], y = new double[2];
        public double CalculateLength()
        {
            length = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));
            length = Math.Round(length, 2);
            return length;
        }

        public void input(string s)
        {
            Console.WriteLine("Enter the co-ordinates for " + s);
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
