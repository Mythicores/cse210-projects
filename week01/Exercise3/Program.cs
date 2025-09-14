using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string input = Console.ReadLine();
        //int number = int.Parse(input);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string GuessInput = Console.ReadLine();
        int guess = int.Parse(GuessInput);

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            GuessInput = Console.ReadLine();
            guess = int.Parse(GuessInput);

        }
        if (guess == number)
        {
           Console.WriteLine("Congrats! You guessed right!");
        }
        
    }
    
}