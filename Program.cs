/*
Author: Kate Schryver
Date: 01/23/2023
Description: Deliverable 2- Conditional Statements
Ask for numerical grade, output letter grade
*/
using System;
namespace Deliverable2_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter class grade:");
                decimal n1 = decimal.Parse(Console.ReadLine());
                if (n1 >= 90)
                {
                    Console.WriteLine("Your letter grade is A");
                    Console.ReadKey(true);
                }
                else if ((n1 >= 80) && (n1 < 90))
                {
                    Console.WriteLine("Your letter grade is B");
                    Console.ReadKey(true);
                }
                else if ((n1 >= 70) && (n1 < 80))
                {
                    Console.WriteLine("Your letter grade is C");
                    Console.ReadKey(true);
                }
                else if ((n1 >= 60) && (n1 < 70))
                {
                    Console.WriteLine("Your letter grade is D");
                    Console.ReadKey(true);
                }
                else if (n1 < 60)
                {
                    Console.WriteLine("Your letter grade is F");
                    Console.ReadKey(true);
                }
            }  
          catch
            {
                Console.WriteLine("Please enter numerical grade, not letter grade.");
                Console.ReadKey(true);
            }
        }
    }
}