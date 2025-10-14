using System.ComponentModel;

public class Activity
{
    private int _sessionLength;
    private string _welcomeMessage;
    private string _description;
    private string _endingMessage;
    private List<string> _spinner;
    private int _loopingLength;
    private string _activityName;

    public Activity()
    {
        _welcomeMessage = "No activity entered.";
        _endingMessage = "No ending message entered.";
        _loopingLength = 0;
    }
    public Activity(string activityName, int sessionLength, string description)
    {
        _activityName = activityName;
        _welcomeMessage = SetWelcomeMessage(activityName);
        _endingMessage = SetEndingMessage(activityName, sessionLength);
        _spinner = ["|", "/", "-", @"\"];
        _description = SetDescription(description);
    }

    public string Menu()
    {
        return "Menu options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit";
    }

    public void SetSessionLength(int sessionLength)
    {
        _sessionLength = sessionLength;
        _endingMessage = SetEndingMessage(_activityName, sessionLength);
    }

    public int GetSessionLength()
    {
        return _sessionLength;
    }
    public void RunSpinner()
    {
        _loopingLength = 1;
        Thread spinner = new Thread(() =>
        {
            while (_loopingLength == 1)
            {
                foreach (string pane in _spinner)
                {
                    Console.Write(pane);
                    Thread.Sleep(200);

                    Console.Write("\b");
                }
            }
        });
        spinner.Start();
    }
    public void StopSpinner()
    {
        _loopingLength = 0;
    }

    private string SetWelcomeMessage(string activityName)
    {
        string message = $"Welcome to the {activityName}!";
        return message;
    }
    private string GetWelcomeMessage()
    {
        return _welcomeMessage;
    }
    private string SetEndingMessage(string activityName, int sessionLength)
    {
        string message = $"Well Done!\n\nYou have completed {sessionLength} seconds of the {activityName} Activity!";
        return message;
    }
    public string GetEndingMessage()
    {
        return _endingMessage;
    }
    private string SetDescription(string description)
    {
        string message = $"\n\nThis activity will {description}\n\nHow long would you like your session? (in seconds):";
        return message;
    }
    private string GetDescription()
    {
        return _description;
    }
    public string FullIntro()
    {
        string welcomeMessage = GetWelcomeMessage();
        string description = GetDescription();
        string message = welcomeMessage + description;
        return message;
    }
    public void GetReady()
    {
        Console.Clear();
        Console.Write("Get Ready. . .");
        RunSpinner();
        Thread.Sleep(3000);
        StopSpinner();
        Console.Clear();
    }
    public void DisplayCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string number = i.ToString();
            Console.Write(number);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected DateTime GetEndTime(int sessionLength)
{
    return DateTime.Now.AddSeconds(sessionLength);
}

    protected bool IsTimeExceeded(DateTime endTime)
    {
        return DateTime.Now >= endTime;
    }
    protected string ChooseRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int listAmount = prompts.Count();
        int randomNumber = random.Next(listAmount);
        return prompts[randomNumber];
    }
}