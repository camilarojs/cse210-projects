using System;

class Activity
{
    private string _date;
    private int _lengthMinutes;
    private string _activityName;

    public Activity(string date, int lengthMinutes, string activityName)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
        _activityName = activityName;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public string GetActivityName()
    {
        return _activityName;
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
        return $"{_date} {_activityName} ({_lengthMinutes} min): Distance {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}