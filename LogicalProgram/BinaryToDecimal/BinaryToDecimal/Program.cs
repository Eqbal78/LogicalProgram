using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num, bin, dec = 0, baseVal = 1, rem;
            Console.WriteLine("Enter Binary Number:");
            num = int.Parse(Console.ReadLine());
            bin = num;
            while (num > 0)
            {
                rem = num % 10;
                dec = dec + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + bin);
            Console.Write("\nDecimal: " + dec);
            
        }
    }
}
