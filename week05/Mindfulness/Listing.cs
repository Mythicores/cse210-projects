public class Listing : Activity
{
    List<string> _prompts = new List<string>();

    public Listing(int sessionLength) : base("Listing", sessionLength, "help you reflect on the good things in life by having you list as many things as you can in a certain area.")
    {
        PopulatePrompts();
    }

    private void PopulatePrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    private string DisplayPrompt()
    {
        string prompt = ChooseRandomPrompt(_prompts);
        string display = $"List as many responses as you can to the following prompt\n\n --- {prompt} --- \n\nYou may begin in:";
        return display;
    }
    public void Run()
    {
        GetReady();
        Console.WriteLine(FullIntro());
        SetSessionLength(int.Parse(Console.ReadLine())); //Read users response and set the SessionLength to equal the response (after converted to an int).
        Console.Clear();
        Console.WriteLine(DisplayPrompt());
        DisplayCountDown(5);
        DateTime endtime = GetEndTime(GetSessionLength());
        int itemcount = 0;
        while (IsTimeExceeded(endtime) == false)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemcount++;
        }
        Console.WriteLine($"You listed {itemcount} items!\n\n");
        DisplayCountDown(5);
        Console.WriteLine(GetEndingMessage());

    }
}