public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"Completed {_amountCompleted}/{_target} times - {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}