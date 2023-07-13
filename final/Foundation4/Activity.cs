using System;

public abstract class Activity 
{
    //arrtibutes
    private string _date;
    private int _minutes;

    //constructors
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    //getter and setter
    public int GetMinutes()
    {
        return _minutes;
    }    

    //behavior
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
    public string GetSummary()
    {
        string summary = $"{_date} {GetType().Name} ({_minutes} min): Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} per km";
        return summary;
    } 

}