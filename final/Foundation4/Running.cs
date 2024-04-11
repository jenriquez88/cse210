public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetLengthInMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Running ({GetLengthInMinutes()} min) - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
