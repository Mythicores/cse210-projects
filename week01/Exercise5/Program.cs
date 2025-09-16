using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName("What's your name? ");
        int UserNumber = PromptUserNumber("What's your favorite number? ");
        SquareNumber(UserNumber);
        DisplayResult(UserName, UserNumber);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName(string UserName)
        {
            Console.Write($"{UserName}");
            UserName = Console.ReadLine();
            return UserName;
        }
        static int PromptUserNumber(string UserNumber)
        {
            Console.Write($"{UserNumber}");
            string StringNumber = Console.ReadLine();
            int number = int.Parse(StringNumber);
            return number;
        }
        static int SquareNumber(int SquaredNumber)
        {
            SquaredNumber ^= 2;
            return SquaredNumber;
        }
        static void DisplayResult(string UserName, int SquaredNumber)
        {
            Console.WriteLine($"User: {UserName}");
            Console.WriteLine($"User's number: {SquaredNumber}");
        }
}