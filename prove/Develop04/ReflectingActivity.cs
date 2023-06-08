using System;

public class ReflectingActivity : Activity
{
    //attribute
    private string _prompt;
    private string _question;
    
    //constructor
    public ReflectingActivity()
        : base("Reflecting")
    {
    }

    //behavior
    public void GetRandomPrompt()
    {   
        string[] prompts = { "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." };
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Length);
        //Console.WriteLine(prompts[randomIndex]); 
        _prompt = prompts[randomIndex];
    }
    public void DisplayRandomPrompt()
    {  
        GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:\n"); 
        Console.WriteLine($" --- {_prompt} ---\n"); 
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }
    public void GetReflectQuestions()
    {   
        string[] questions = { "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" };
        Random random = new Random();
        int randomIndex = random.Next(0, questions.Length);
        _question = questions[randomIndex];
    }
    public void DisplayReflectQuestions(int durationSecond)
    {   
        //GetRandomPrompt();
        if (Console.ReadLine() == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in...");
            base.PauseCountdown(5);
            Console.Clear();

            
            int ponderSec = 10;
            int accumulationSec = 0;
            while ( accumulationSec < durationSecond )
            {  
                GetReflectQuestions();
                Console.Write($" > {_question} "); 
                base.PauseSpinner(ponderSec);
                Console.WriteLine();
                accumulationSec += ponderSec;
            }
            
        };
        // Console.WriteLine("Consider the following prompt:\n"); 
        // Console.WriteLine($" --- {_prompt} ---\n"); 
        // Console.WriteLine("When you have something in mind, press enter to continue.");
        
    }

}