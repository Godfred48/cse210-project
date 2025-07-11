using System;

class Program
{
    static void Main(string[] args)
    {
        //Request FirstName
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        //Request LastName
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

    }
}