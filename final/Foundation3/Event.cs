using System;

public class Event 
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }
    // public string GetDescription()
    // {
    //     return _description;
    // }
    public string GetDate()
    {
        return _date;
    }
    // public string GetTime()
    // {
    //     return _time;
    // }
    // public string GetAddress()
    // {
    //     return _address;
    // }

    public string GetStandardDetails()
    {
        string standardDetils = $"Title: {_eventTitle}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address}";
        return standardDetils;
    }

}