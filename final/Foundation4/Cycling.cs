public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * GetLengthInMinutes() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Cycling ({GetLengthInMinutes()} min) - Speed {_speed} kph, Distance {GetDistance()} km, Pace: {GetPace()} min per km";
    }
}
