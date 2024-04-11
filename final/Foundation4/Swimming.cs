public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLengthInMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Swimming ({GetLengthInMinutes()} min) - Laps {_laps}, Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
