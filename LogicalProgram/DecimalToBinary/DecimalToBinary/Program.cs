using System;

namespace DecimalToBinary
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.Write("Binary of the given number " + result );
          
        }
    }
}
