using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Input string
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // Reads input as string
        Console.WriteLine("Hello, " + name + "!");

        // Example 2: Input integer
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine()); // Converts string input to int
        Console.WriteLine("You are " + age + " years old.");

        // Example 3: Input double (decimal number)
        Console.Write("Enter your height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine()); // Converts to double
        Console.WriteLine("Your height is " + height + " meters.");

        // Example 4: Input character
        Console.Write("Enter a single character (e.g., Y/N): ");
        char choice = Convert.ToChar(Console.ReadLine()); // Reads first character
        Console.WriteLine("You entered: " + choice);

        // Example 5: Input boolean (true/false)
        Console.Write("Do you like programming? (true/false): ");
        bool likesProgramming = Convert.ToBoolean(Console.ReadLine()); // Converts string to bool
        Console.WriteLine("Likes programming: " + likesProgramming);

        // Example 6: Multiple inputs in one line
        Console.Write("Enter your city and country (separated by space): ");
        string[] location = Console.ReadLine().Split(' '); // Splits input into parts
        Console.WriteLine("City: " + location[0] + ", Country: " + location[1]);

        // Example 7: Input with parsing (safer than Convert)
        Console.Write("Enter your grade (int): ");
        if (int.TryParse(Console.ReadLine(), out int grade)) // TryParse prevents crash
        {
            Console.WriteLine("Your grade is: " + grade);
        }
        else
        {
            Console.WriteLine("Invalid input! Not an integer.");
        }
    }
}
