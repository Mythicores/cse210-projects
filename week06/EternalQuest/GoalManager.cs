using Microsoft.VisualBasic;
using System.IO;
using System.Reflection;
public class GoalManager
{
    private string _menu;
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public GoalManager()
    {
        SetMenu();
    }

    private void SetMenu()
    {
        _menu = $"\n\nYou have {_score} points.\n\nMenu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a choice from the menu: ";
    }
    public string GetMenu()
    {
        return _menu;
    }

    private void DisplayList()
    {
        int numberedList = 0;
        foreach (var goal in _goals)
        {
            numberedList += 1;
            Console.WriteLine($"{numberedList}. {goal.GetStringRepresentation()}");
        }
    }
    private void AppendFile(string filename, string input)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine(input);
        }
    }
    private void LoadFile(string filename)
    {
        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("File Not found.");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Split(":")[1].Trim());
                continue;
            }
            var parts = line.Split("|");

            string name = parts[0].Trim();
            string description = parts[1].Trim();
            string type = parts[2].Trim();
            int points = int.Parse(parts[3].Trim());

            Goal goal = null;

            if (type.Equals("Simple Goal"))
            {
                goal = new SimpleGoal(name, description, points);
            }
            else if (type.Equals("Eternal Goal"))
            {
                goal = new EternalGoal(name, description, points);
            }
            else if (type.Equals("Checklist"))
            {
                if (parts.Length >= 7)
                {
                    int target = int.Parse(parts[4].Trim());
                    int bonus = int.Parse(parts[5].Trim());
                    var checklist = new CheckListGoal(name, description, points, target, bonus);
                    goal = checklist;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                continue;
            }
            _goals.Add(goal);
        }
        
    }
    

    public void Run()
    {
        Console.Clear();
        string userChoice = "";
        
        userChoice = LowerInput(_menu);
        while (userChoice != "6" && userChoice != "quit")
        {
            if (userChoice == "1")
            {
                string goalType = Input("The types of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of goal would you like to create? ");

                if (goalType == "1" || goalType == "simple" || goalType == "simple goal")
                {
                    string goalName = Input("What is the name of your goal? ");
                    string goalDescription = Input("Please write a description: ");
                    int goalPoints = int.Parse(Input("How many points is this goal worth? "));
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(simpleGoal);
                    Input("Goal saved! Press enter to continue: ");
                }
                else if (goalType == "2" || goalType == "eternal" || goalType == "eternal goal")
                {
                    string goalName = Input("What is the name of your goal? ");
                    string goalDescription = Input("Please write a description: ");
                    int goalPoints = int.Parse(Input("How many points is this goal worth? "));
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(eternalGoal);
                    Input("Goal saved! Press enter to continue: ");
                }
                else if (goalType == "3" || goalType == "checklist" || goalType == "checklist goal")
                {
                    string goalName = Input("What is the name of your goal?");
                    string goalDescription = Input("Please write a description: ");
                    int singleGoalPoints = int.Parse(Input("How many points is each goal worth? "));
                    int goalAmount = int.Parse(Input("How many times would you like to complete it? "));
                    int bonusPoints = int.Parse(Input("How many bonus points should you get when you reach the goal? "));
                    CheckListGoal checkListGoal = new CheckListGoal(goalName, goalDescription, singleGoalPoints, goalAmount, bonusPoints);
                    _goals.Add(checkListGoal);
                    Input("Goal saved! Press enter to continue: ");
                }
            }
            else if (userChoice == "2")
            {
                Console.Clear();
                DisplayList();
                Input("Press enter to continue: ");
            }
            else if (userChoice == "3")
            {
                string filename = Input("What's the name of the file? ");
                AppendFile(filename, $"Score:{_score}");
                foreach (var goal in _goals)
                {
                    string formattedGoal = $"{goal.GetName()}|{goal.GetDescription()}|{goal.GetGoalType()}|{goal.GetPoints()}";
                    if (goal is CheckListGoal checkListGoal)
                    {
                        formattedGoal += $"|{checkListGoal.GetTarget}|{checkListGoal.GetBonusPoints()}";
                    }
                    AppendFile(filename, formattedGoal);
                    Input("File saved! Press enter to continue: ");
                }
            }
            else if (userChoice == "4")
            {
                string filename = Input("What is the name of the file? ");
                LoadFile(filename);
                Input("File Loaded! Press enter to continue: ");
            }
            else if (userChoice == "5")
            {
                Console.Clear();
                DisplayList();
                int goalIndex = int.Parse(Input("Which goal did you accomplish? ")) - 1;
                if (goalIndex < 0 || goalIndex >= _goals.Count())
                {
                    Console.WriteLine("Invalid selection.");
                }
                else
                {
                    Goal completedGoal = _goals[goalIndex];
                    completedGoal.RecordEvent();
                    _score += completedGoal.GetPoints();
                    Console.WriteLine($"+{completedGoal.GetPoints()}pts!\n\nYou now have {_score} points!");

                    if (completedGoal is CheckListGoal checklist && checklist.IsComplete() == true)
                    {
                        Console.WriteLine("Checklist completed! You reached the goal!");
                        _score += checklist.GetBonusPoints();
                    }
                }

                Input("Press Enter to continue: ");
            }
            else if (userChoice == "")
            {
                //Purposefully empty
            }
            else
            {
                Console.WriteLine("That's not an option, please try again.");
            }
            Console.Clear();
            SetMenu();
            userChoice = LowerInput(_menu);
        }
        Console.Clear();
        Console.WriteLine("Thanks for using this program!");
    }
    static string LowerInput(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine().ToLower();
        return input;
    }
    static string Input(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();
        return input;
    }
    
}