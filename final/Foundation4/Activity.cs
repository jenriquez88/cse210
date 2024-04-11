using System.Runtime.CompilerServices;

public class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public DateTime GetDate()
    {
        return _date;
    }
    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - ";
    }
}
