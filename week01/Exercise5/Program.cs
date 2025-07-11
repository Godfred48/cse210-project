using System;

class Program
{
    static void Main(string[] args)
    {
        string welcome = "Welcome to the program!";
        DisplayWelcome(welcome);

        // Prompt and read user's name
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();

        // Prompt and read user's favorite number
        Console.Write("Please enter your favorite number: ");
        string usernumber = Console.ReadLine();
        int usernum = int.Parse(usernumber);

        // Calculate square
        int square = usernum * usernum;

        // Call remaining functions
        PromptUserName(username);
        PromptUserNumber(usernum);
        SquareNumber(square);
        DisplayResult(username, square);
    }

    static void DisplayWelcome(string message)
    {
        Console.WriteLine(message);
    }

    static void PromptUserName(string user)
    {
        Console.WriteLine($"Hello, {user}!");
    }

    static void PromptUserNumber(int number)
    {
        Console.WriteLine($"Your favorite number is: {number}");
    }

    static void SquareNumber(int number)
    {
        Console.WriteLine($"Its square is: {number}");
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}.");
    }
}
