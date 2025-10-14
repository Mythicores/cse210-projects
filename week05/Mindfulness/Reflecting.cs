using System.Runtime.CompilerServices;

public class Reflecting : Activity
{
    //Attributes

    List<string> _experiences = new List<string>();
    List<string> _questions = new List<string>();

    //Constructors

    public Reflecting(int sessionLength) : base("Reflecting", sessionLength, "help you reflect on times in your life when you have shown strength and resilience. This can help you realize and see the miracles God has wrought upon you.")
    {
        PopulateExperiences();
        PopulateQuestions();
    }

    //Methods

    private void PopulateExperiences()
    {
        _experiences.Add("Think of a time when you stood up for someone else.");
        _experiences.Add("Think of a time when you did something really difficult.");
        _experiences.Add("Think of a time when you helped someone in need.");
        _experiences.Add("Think of a time when you did something truly selfless.");
    }
    private void PopulateQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    private string ExperiencePrompt()
    {
        string prompt = ChooseRandomPrompt(_experiences);
        string display = $"Consider the following prompt:\n\n --- {prompt} --- \n\nWhen you have something in mind, press enter to continue\n";
        return display;
    }
    public void Run()
    {
        GetReady();
        Console.WriteLine(FullIntro());
        SetSessionLength(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.Write(ExperiencePrompt());
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        DisplayCountDown(5);
        Console.Clear();
        DateTime endtime = GetEndTime(GetSessionLength());
        while (IsTimeExceeded(endtime) == false)
        {
            Console.WriteLine(ChooseRandomPrompt(_questions) + " ");
            RunSpinner();
            Thread.Sleep(10000);
            StopSpinner();
            Console.Write(" \b");
            Console.WriteLine();
        }
        Console.WriteLine(GetEndingMessage());
        DisplayCountDown(5);
    }
}