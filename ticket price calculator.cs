using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age < 0)
            {
                Console.WriteLine("Error: Age cannot be negative.");
            }
            else
            {
                // Use ternary operator to determine price
                double ticketPrice = (age <= 12 || age >= 65) ? 7.00 : 10.00;

                Console.WriteLine($"Your ticket price is: GHC{ticketPrice:0.00}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

