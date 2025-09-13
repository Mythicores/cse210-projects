using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please write your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You got {letter}!");

        if (grade > 70)
        {
            Console.Write("Congratulations! You passed!");
        }


        if (grade < 70)
            {
                Console.Write("Better luck next time!");
            }

    }
}