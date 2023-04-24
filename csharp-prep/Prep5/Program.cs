using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squareNumber = SquareNumber(number);
            DisplayResult(name, squareNumber);
        }
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int num)
        {
            return num * num;
        }
        static void DisplayResult(string name, int squareNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        }


    }
}