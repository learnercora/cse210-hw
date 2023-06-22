
public class Menu
{
    // private int _score;
    // public Menu(int score)
    // {
    //     _score = score;
    // }
    public void DisplayMenu()//int score)
    {
        //Console.WriteLine($"You have {score} point.");
        Console.WriteLine("Please select one of the following choice: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
    }
    public string AskBehavior()
    {
        Console.Write("What would you like to do? ");
        string _choice = Console.ReadLine();
        return _choice;
    }
}