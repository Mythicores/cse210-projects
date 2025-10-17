using System.Formats.Asn1;

public class CheckListGoal : Goal
{
    private int _amountFinished;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountFinished = 0;
        _target = target;
        _bonus = bonus;
        SetGoalType("Checklist Goal");
    }
    public int GetBonusPoints()
    {
        return _bonus;
    }
    public int GetTarget()
    {
        return _target;
    }
    public override void RecordEvent()
    {
        if (_amountFinished != _target)
        {
            _amountFinished += 1;
        }
        else if (_amountFinished >= _target)
        {
            _amountFinished = _target;
        }
    }
    public override bool IsComplete()
    {
        if (_amountFinished == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public override string GetStringRepresentation()
    {
        string checkmark = IsComplete() ? "[x]" : "[ ]";
        return $" {checkmark} {GetName()} ({GetDescription()} -- Currently completed {_amountFinished}/{_target})";
    }
    public override string GetDetailsString()
    {
        return "";
    }
}