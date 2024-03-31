public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are always "completed" when recorded
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},0"; // Eternal goals are never complete
    }
}