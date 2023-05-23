using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        bool run = true;

        Reference reference = new Reference("Proverbs","3","5","6");
        string referenceOutput = reference.GetReference();
        //string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        
        
        // Word word = new Word("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        // string wordOutput = word.GetWord();
        string wordOutput = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(referenceOutput, wordOutput);

        // string response = null;

        while (run)
        {
            string scriptureOutput = scripture.GetTextOfScripture();
            Console.WriteLine(scriptureOutput);
            Console.WriteLine("\nPress 'Enter' to continue or type 'quit' to stop.");
            
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                Console.WriteLine("See you soon.");
                break;
            }
            else
            {
                scripture.HideWords();

                if(scripture.IsCompletelyHidden())
                {
                    Console.WriteLine(scripture.GetTextOfScripture());
                    Console.WriteLine("\nGreat Job!\n");   
                    break;
                }

            }
        }    
    }
}

// Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
// Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
// Clear the console screen and display the complete scripture, including the reference and the text.
// Prompt the user to press the enter key or type quit.
// If the user types quit, the program should end.
// If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
// The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
// When all words in the scripture are hidden, the program should end.
// When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)