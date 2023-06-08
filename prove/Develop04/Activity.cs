using System;

public class Activity 
{
    //arrtibutes
    private string _activityName;
    private string _description;
    private int _durationSecond;

    //behaviors
    public string GetActivityDescription()
    {
        if (_activityName=="Breathing")
        {
            _description = "Smile, breathe, and take it slow. Doing this activity will help you to relax.";
        }
        else if (_activityName=="Reflecting")
        {
            _description = "This activity helps you look back on times in your life when you've shown strength and resilience. It enables you to recognize your own power and how you can apply it in different areas of your life.";
        }
        else
        {
            _description = "This activity will have you make a list that will help you remember and ponder good moments in your life so that you may continue to have meaning and purpose in your own journey.";
        }
        return _description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName} Activity.\n");
        Console.WriteLine($"{GetActivityDescription()}\n");
    }
    public void DisplayEndMessage(int durationSecond)
    {
        Console.WriteLine($"\nWell done!!");
        PauseSpinner(3);
        Console.WriteLine($"\nYou have completed another {durationSecond} seconds of the {_activityName} Activity.");
        PauseSpinner(3);
    }
    public void DisplayGetReady()
    {
        Console.Clear();
        Console.WriteLine($"Get ready...");
        PauseSpinner(4);
        Console.WriteLine();
    }
    public void AskDurationSecond()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
        string second = Console.ReadLine();
        _durationSecond = int.Parse(second);
        //return int.Parse(second);
    }
    public int GetDurationSecond()
    {
        return _durationSecond;

    }

    public void PauseSpinner(int second)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(second); 
        while (DateTime.Now < futureTime)
        {
            foreach(string spinner in new List<string>() { "\\", "/", "-" })
            {
                Console.Write(spinner);
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the character
            }
        }        
    }
    
    public void PauseCountdown(int second)
    {
        // string countdownResult = "";
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(second); 
        while (second != 0)
        {
            //countdownResult += second.ToString();
            Console.Write(second);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            //countdownResult += "\b \b";
            second -= 1;
        }
    }

    //constructors
    public Activity(string activityName)
    {
        _activityName = activityName;
    }

}