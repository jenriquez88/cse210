using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    public bool _isComplete;



    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {ShortName}: {Description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName},{Description},{Points},{(_isComplete ? 1 : 0)}";
    }
}