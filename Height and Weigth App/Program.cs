using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input.ToLower() != "q")
            {
                Console.WriteLine("Enter your date of birth (MM/DD/YYYY) or type 'q' to quit:");
                input = Console.ReadLine();
                if (input.ToLower() != "q")
                {
                    DateTime dob = Convert.ToDateTime(input);
                    TimeSpan age = DateTime.Now - dob;
                    int totalDays = age.Days;
                    int years = totalDays / 365;
                    int remainingDays = totalDays % 365;
                    int months = remainingDays / 30;
                    remainingDays = remainingDays % 30;
                    int weeks = remainingDays / 7;
                    remainingDays = remainingDays % 7;
                    Console.WriteLine("You are " + years + " years, " + months + " months, " + weeks + " weeks, and " + remainingDays + " days old.");
                }
            }
        }
    }
}
