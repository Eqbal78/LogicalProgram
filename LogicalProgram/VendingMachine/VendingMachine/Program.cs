using System;

namespace VendingMachine
{
    class Program
    {
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[9];

            
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                    Console.WriteLine("amount"+amount);
                }
            }

            
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount:");
            int amount = int.Parse(Console.ReadLine());
            countCurrency(amount);
        }
    }
}
