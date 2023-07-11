using System;

public class Lectures : Event
{
    private string _speaker;
    private int _limitCapacity;
    private string _type = "Lectures";
    

    public Lectures(string speaker, int limitCapacity, string eventTitle, string description, string date, string time, string address) 
        : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _limitCapacity = limitCapacity;
    }

    public string GetFullDetails()
    {
        string fullDetils = $"{GetStandardDetails()}, Speaker: {_speaker}, Limit Capacity: {_limitCapacity}  ";
        return $"{fullDetils}";
    }
    public string GetShortDescription()
    {
        return $"Type: {_type} / Title: {GetEventTitle()} / Date: {GetDate()}";
    }


}