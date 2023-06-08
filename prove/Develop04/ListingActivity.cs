using System;

public class ListingActivity : Activity
{
    //attribute
    private string _prompt;
    
    //constructor
    public ListingActivity()
        : base("Listing")
    {
    }
    //behavior
    public void GetRandomPrompt()
    {   
        string[] prompts = { "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?" };
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Length);
        _prompt = prompts[randomIndex];
    }
    public void DisplayRandomPrompt()
    {  
        GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:"); 
        Console.WriteLine($" --- {_prompt} ---"); 
    }
    public void ListItems(int durationSecond)
    {   
        
        Console.Write("You may begin in...");
        base.PauseCountdown(5);
        Console.WriteLine();
        
        List<string> listItems = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationSecond);
        
        while (DateTime.Now < futureTime) {  
            // if (startTime == futureTime) {
            //     break;
            // }
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item != "")
            {
                listItems.Add(item);
            }
        }
        Console.WriteLine($"You listed {listItems.Count} items!");
        // foreach (string str in listItems)
        // {
        //     Console.WriteLine(str);
        // }
    }

}