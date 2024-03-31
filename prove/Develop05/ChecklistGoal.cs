public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    private int _bonus;

    public int AmountCompleted { get => _amountCompleted; }
    public int Target { get => _target; }
    public int Bonus { get => _bonus; }

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
        return $"Completed {_amountCompleted}/{Target} times - {ShortName}: {Description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName},{Description},{Points},{_amountCompleted},{Target},{Bonus}";
    }
}