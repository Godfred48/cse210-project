using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Checker");

        // Request for users users score 
        Console.WriteLine("Enter your Score:");
        string score = Console.ReadLine();
        //always notwe that inputs that are number are taken as string
        // and ought to be converted into a number.
        int gradeScore = int.Parse(score);

        //determine users grade based on the score
        string letter = "";

        if (gradeScore >= 90)
        {
            letter = "A";
        }
        else if (gradeScore >= 80)
        {
            letter = "B";
        }
        else if (gradeScore >= 70)
        {
            letter = "C";
        }
        else if (gradeScore >= 60)
        {
            letter = "D";
        }
        else if(gradeScore < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Score:{gradeScore} Grade: {letter}");

        // display statement if the user passed the course
        if (gradeScore >= 70)
        {
            Console.WriteLine("Congratulations!!! you passed the cousre.");
        }
        else Console.WriteLine("Sorry you didn't pass the course. Try again!!!");

    }
}