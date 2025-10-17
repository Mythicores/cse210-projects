using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{

    bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
        SetGoalType("Simple Goal");
    }
    
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        if (_isComplete == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override string GetStringRepresentation()
    {
        bool isComplete = IsComplete();
        string stringRepresentation = $" [ ] {GetName()} ({GetDescription()})";
        if (isComplete == true)
        {
            stringRepresentation = $" [x] {GetName()} ({GetDescription()})";
        }
        return stringRepresentation;
    }
}