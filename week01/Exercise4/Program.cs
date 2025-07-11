using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //declearing new List
        List<int> listnumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers of numbers. type 0 when finished.");

        int numbers;
        // do while keeping thuser to typre numbers till 0
        do
        {
            Console.Write("Enter number: ");
            string numberList = Console.ReadLine();
            numbers = int.Parse(numberList);
            // adding numbers to the new list
            listnumbers.Add(numbers);
        } while (numbers != 0);

        //finding the sum and average 
        int total = 0;
        int average = 0;
        int figure = listnumbers.Count;
        int max = listnumbers[0];

        // looping through the new list
        foreach (int num in listnumbers)
        {
            //finding max number 
            if (max < num)
            {
                max = num;
            }
            //finding total & average
            total += num;
            average = total / figure;
        }

             //DISPLAY RESULT    
            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The averae is: {average}");
            Console.WriteLine($"The largest number is: {max}");
    }
}