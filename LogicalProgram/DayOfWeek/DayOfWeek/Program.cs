using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a Year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            Console.Write("Date is: " + inputDate);
            Console.WriteLine("\nWeek is: " + inputDate.DayOfWeek);

            DayOfWeek today = inputDate.DayOfWeek;
            if (today == DayOfWeek.Monday | today == DayOfWeek.Tuesday | today == DayOfWeek.Wednesday | today == DayOfWeek.Thursday | today == DayOfWeek.Friday)
            {
                Console.WriteLine("DO WORK");
            }
            else
            {
                Console.WriteLine("WEEK OFF DAY");
            }
        }
    }
}
