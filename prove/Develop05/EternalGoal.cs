public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {ShortName}: {Description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName},{Description},{Points},0";
    }
}