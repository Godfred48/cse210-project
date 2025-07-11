using System;

class Program
{
    static void Main(string[] args)
    {    
        //initializing variable for random number.
        Random randomNumber = new Random();
        int random = randomNumber.Next(1, 101);
        string outcome = "";
         //Request Magic Number
        Console.WriteLine("The Computer has generated a random from 1 to 100?");
        
        //Using while loops to find the correct guess.
        while (outcome != "You guessed it !")
        {
            //Guess magic number
            Console.Write("What is your guess?");
            string guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);

            //outcome 
            if (guess < random)
            {
                outcome = "Higher";
            }
            else if (guess > random)
            {
                outcome = "Lower";
            }
            else if (guess == random)
            {
                outcome = "You guessed it !";
            }
            Console.WriteLine(outcome);
        }
       
    }
}