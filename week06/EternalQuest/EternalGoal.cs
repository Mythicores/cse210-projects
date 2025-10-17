public class EternalGoal : Goal
{
    
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        SetGoalType("Eternal Goal");
    }
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation = $" [ ] {GetName()} ({GetDescription()})";
        return stringRepresentation;
    }
    
}