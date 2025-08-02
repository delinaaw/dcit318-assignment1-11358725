using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numerical grade (0-100): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
            else
            {
                string letterGrade = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };

                Console.WriteLine($"Letter grade: {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
