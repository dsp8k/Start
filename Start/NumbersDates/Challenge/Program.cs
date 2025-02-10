// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Prompt the user to enter a date or 'exit' to quit
            Console.Write("Enter a date (yyyy-MM-dd) or type 'exit' to quit: ");
            string input = Console.ReadLine();

            // Check if the user wants to exit the program
            if (input.Trim().ToLower() == "exit")
                break;

            // Try parsing the input into a valid DateTime object
            if (DateTime.TryParse(input, out DateTime enteredDate))
            {
                // Get the current date without time component
                DateTime currentDate = DateTime.Now.Date;
                
                // Calculate the difference in days between entered date and current date
                int difference = (enteredDate - currentDate).Days;

                // Display appropriate message based on the difference
                if (difference > 0)
                    Console.WriteLine($"The entered date is {difference} days in the future.");
                else if (difference < 0)
                    Console.WriteLine($"The entered date was {-difference} days ago.");
                else
                    Console.WriteLine("The entered date is today!");
            }
            else
            {
                // Handle invalid date input
                Console.WriteLine("Invalid date format. Please enter a valid date in the format yyyy-MM-dd.");
            }
        }
    }
}
