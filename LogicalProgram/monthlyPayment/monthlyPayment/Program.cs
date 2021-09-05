using System;

namespace monthlyPayment
{
    class Program
    {
        static double Amount(int p, double r, int y)
        {
            y = y * 12;
            r = r / (100 * 12);
            return  (p * r) / (1 - Math.Pow(1 + r, -y));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("principal");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Rate");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Year");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Payment Amount: " + Amount(p, r, y));        
        }
    }
}
