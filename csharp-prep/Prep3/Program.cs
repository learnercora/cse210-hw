using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        
        while (playAgain.ToLower() == "yes")
            {

            //Console.WriteLine("Hello Prep3 World!");
            //Console.Write("What is the magic number? ");
            //string magicNumber = Console.ReadLine();
            Random randomGenerator = new Random();
            int intMagicNumber = randomGenerator.Next(1, 101);
            int count = 0;
            bool game = true;
            
            while (game)
            {
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                count++;
                //int intMagicNumber = int.Parse(magicNumber);
                int intGuessNumber = int.Parse(guessNumber);
                
                
                if (intGuessNumber > intMagicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (intGuessNumber < intMagicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }
            Console.WriteLine($"You guess {count} times.");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
            
        }
        Console.Write("Thank you for playing with us.");


    }
}