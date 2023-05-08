using System.Collections.Generic;

public class PromptGenerator 
{
    List<string> _prompts = new List<string>(){
        "What did I accomplish today that made a difference?",
        "Did I attempt to meet someone new today?",
        "What made you feel angry today?", 
        "What event or occurrence would you like to remember?",
        "What made you feel happy today?" };
    public Random _randomNum = new Random();

    public string GetPrompt()
    {
        int index = _randomNum.Next(_prompts.Count());
        // random.Next(maxValue)傳回值的範圍通常包含 0 但不包含 maxValue
        //Console.WriteLine(_prompts[index]);
        return _prompts[index];
        // string content = Console.ReadLine();
        // Console.WriteLine(content);
    }
}