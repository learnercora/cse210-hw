
public class Menu 
{
    public void DisplayMenu()
    {

        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        
    }
    public string AskBehavior()
    {
        Console.Write("Select a choice from the menu: ");
        string _choice = Console.ReadLine();
        return _choice;
    }
}