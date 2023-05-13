using System;
using System.IO;

public class Journal
{    public List<Entry> _entries = new List<Entry>();

    public void AddToEntries(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
                outputFile.WriteLine(entry._response);
                outputFile.WriteLine();
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        string date = "";
        string prompt = "";
        string response = "";
    
        foreach (string line in lines)
        {
            // Console.WriteLine($"line:{line}");
            if (line != "")
            {
                Entry newEntry = new Entry();
                if (line.Contains("Date:"))
                {
                    response = "";
                    string[] parts = line.Split("-");
                    date = parts[0].Split(" ")[1];
                    prompt = parts[1].Split(": ")[1];
                    // newEntry._date = date;
                    // newEntry._prompt = prompt;
                }
                else
                {
                    response = line;
                    //Console.WriteLine($"date:{date} / prompt:{prompt} / response: {response}");
                    
                    // Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._prompt = prompt;
                    newEntry._response = response;
                    _entries.Add(newEntry);
                }
            }
        } 
    }
}
