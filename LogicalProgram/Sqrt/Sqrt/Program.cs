using System;

namespace Sqrt
{
    class Program
    {
        static double squareRoot(double n, double l)
        {
            
            double x = n;
            double root;

            int count = 0;
            while (true)
            {
                count++;
                root = 0.5 * (x + (n / x));

                if (Math.Abs(root - x) < l)
                    break;
                x = root;
            }

            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input");
            double n = double.Parse(Console.ReadLine());
            double l = 0.000000000000001;

            Console.WriteLine(squareRoot(n, l));
        }
    }
}
