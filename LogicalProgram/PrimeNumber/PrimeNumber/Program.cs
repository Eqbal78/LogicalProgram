using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n , a = 0;
            Console.WriteLine("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                 if (n % i == 0)
                 {
                     a++;
                 }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
