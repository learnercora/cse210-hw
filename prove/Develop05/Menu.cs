
public class Menu
{
    public string DisplayMenuAndAskBehavior(int totalScore)
    {
        Console.WriteLine($"\nYou have {totalScore.ToString()} points\n");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goals");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

        Console.Write("\nSelect a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }
    public string DisplayTypeAndAskBehavior()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goals");
        Console.WriteLine("  2. Eternal Goals");
        Console.WriteLine("  3. Checklist Goals");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        return type;
    }
}