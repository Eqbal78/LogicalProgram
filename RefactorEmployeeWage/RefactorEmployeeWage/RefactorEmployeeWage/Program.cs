﻿using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static void EmployeeAttendance()
        {
            int Is_Full_Time = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine("Welcome to Employee Wage Computation Program using C#");
            if (empcheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Emplyoee is Absent");
            }
            
        }
        static void Main(string[] args)
        {
            EmployeeAttendance();
        }
    }
}
