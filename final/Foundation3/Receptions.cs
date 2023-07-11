using System;

public class Receptions : Event
{
    private string _email;
    private string _type = "Receptions";
    

    public Receptions(string email, string eventTitle, string description, string date, string time, string address)
        : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }
    public string GetFullDetails()
    {
        string fullDetils = $"{GetStandardDetails()}, Email: {_email}";
        return $"{fullDetils}";
    }
    public string GetShortDescription()
    {
        return $"Type: {_type} / Title: {GetEventTitle()} / Date: {GetDate()}";
    }

}