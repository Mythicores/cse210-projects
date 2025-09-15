using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. When you're done, type 0");
        List<int> TotalNumbers = new List<int>();
        int sum = 0;
        int number = 0;
        int loops = 0;
        float Average = 0.0F;
        int Largest = 0;
        do
        {

            Console.Write("Enter a number: ");
            string UserInput = Console.ReadLine();
            number = int.Parse(UserInput);
            TotalNumbers.Add(number);
            sum = sum + number;
            loops = loops + 1;
            if (Largest < number)
            {
                Largest = number;
            }

        } while (number != 0);
        loops = loops - 1;
        Average = sum / loops;
        Console.WriteLine($"Total sum: {sum}");
        Console.WriteLine($"Average: {Average}");
        Console.WriteLine($"Largest number: {Largest}");

    }
}