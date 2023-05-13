using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!");

        //新增Journal Class在while之前...才不會每次都歸0
        Journal journal1 = new Journal();

        bool run = true;
        while (run != false)
        {
            //menu
            Menu menu = new Menu();
            menu.DisplayMenu();
            string ans = menu.AskBehavior();
            
            if (ans == "1") //write
            {
                //prompts
                PromptGenerator prompt = new PromptGenerator();
                string p = prompt.GetPrompt();
                Console.WriteLine(p);

                //add to entry
                string content = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._prompt = p;
                newEntry._response = content;
                // newEntry.DisplayEntry();

                journal1.AddToEntries(newEntry);
                //journal1._entries.Add(newEntry); 
                // Console.WriteLine(journal1._entries.Count); //查看是否增進去
            }
            else if (ans == "2") //display
            {
                if (journal1._entries.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("There are no entries in the journal.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("All entries in the journal:");
                    journal1.DisplayAllEntries();
                }
            }
            else if (ans == "3") //load
            {
                if (journal1._entries.Count == 0)
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    journal1.LoadFromFile(filename);
                }
                else
                {
                    Console.WriteLine("You have record some great things in your journal. Would you like to save or discard? ");
                    Console.WriteLine("1. Save");
                    Console.WriteLine("2. Discard");
                    string saveOrDiscard = Console.ReadLine();
                    if (saveOrDiscard == "1")
                    {
                        Console.WriteLine("What is the filename?");
                        string filename = Console.ReadLine();
                        journal1.SaveToFile(filename);
                    }
                    else if (saveOrDiscard == "2")
                    {
                        journal1._entries.Clear();

                    }
                    else
                    {
                        Console.WriteLine("Wrong Input. (Please choose 1 or 2.)");
                    }
                }
                
            }
            else if (ans == "4") //save
            {
                if (journal1._entries.Count == 0)
                {
                    Console.WriteLine("There are no entries in the journal.");
                }
                else
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    journal1.SaveToFile(filename);
                }   
            }
            else if (ans == "5") //quit
            {
                Console.WriteLine("What wonderful memories you created! See you tomorrow!");
                Console.WriteLine();
                run = false;
            }
            else
            {
                Console.WriteLine("Wrong Input. (Please choose 1-5.)");
            }
        }
        
    }
}
