public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string ShortName { get => _shortName; }
    public string Description { get => _description; }
    public int Points { get => _points; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}