using System.ComponentModel.DataAnnotations;

public class Breathing : Activity
{

    public Breathing(int sessionLength) : base("Breathing", sessionLength, "help you relax as it guides you through breathing in and out slowly. Follow the countdowns and relax.")
    {
        
    }
    private int CalculateRepetitions()
    {
        int sessionLength = GetSessionLength();
        int sections = (int)Math.Floor((double)sessionLength / 4);
        return sections;
    }

    public void Run()
    {
        GetReady();
        int repetitions = CalculateRepetitions();
        DateTime endtime = GetEndTime(GetSessionLength());
        while (IsTimeExceeded(endtime) == false)
        {
            Console.Write("\n\nBreathe in... ");
            DisplayCountDown(repetitions);
            Console.Write("\n\nBreathe out...");
            DisplayCountDown(repetitions);
        }
        Console.WriteLine(GetEndingMessage());
    }
}