using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle.");

        Console.Write("Side 1: ");
        string input1 = Console.ReadLine();

        Console.Write("Side 2: ");
        string input2 = Console.ReadLine();

        Console.Write("Side 3: ");
        string input3 = Console.ReadLine();

        // Try parsing inputs
        bool valid1 = double.TryParse(input1, out double side1);
        bool valid2 = double.TryParse(input2, out double side2);
        bool valid3 = double.TryParse(input3, out double side3);

        if (valid1 && valid2 && valid3 && side1 > 0 && side2 > 0 && side3 > 0)
        {
            // Check if it's a valid triangle using the Triangle Inequality Theorem
            if (side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                // Determine triangle type
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The lengths do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numerical values for all sides.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
