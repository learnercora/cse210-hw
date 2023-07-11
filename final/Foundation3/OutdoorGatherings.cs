using System;

public class OutdoorGatherings : Event
{
    private string _weatherStatement;
    private string _type = "OutdoorGatherings";
    

    public OutdoorGatherings(string weatherStatement, string eventTitle, string description, string date, string time, string address)
        : base(eventTitle, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetails()
    {
        string fullDetils = $"{GetStandardDetails()}, Weather: {_weatherStatement}";
        return $"{fullDetils}";
    }
    public string GetShortDescription()
    {
        return $"Type: {_type} / Title: {GetEventTitle()} / Date: {GetDate()}";
    }

}