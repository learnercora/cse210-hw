using System;

class Program
{
    static void Main(string[] args)
    {
        // Core1 & Core3
        Console.Write("Enter your grade percentage: ");
        string gradeStr = Console.ReadLine();
        int gradeInt = int.Parse(gradeStr);
        string letter;
        
        if (gradeInt >= 90)
        {
            //Console.WriteLine("Your letter grade is A.");
            letter = "A";
        }
        else if (gradeInt < 90 && gradeInt >= 80)
        {
            //Console.WriteLine("Your letter grade is B.");
            letter = "B";
        }
        else if (gradeInt < 80 && gradeInt >= 70)
        {
            //Console.WriteLine("Your letter grade is C.");
            letter = "C";
        }
        else if (gradeInt < 70 && gradeInt >= 60)
        {
            //Console.WriteLine("Your letter grade is D.");
            letter = "D";
        }
        else 
        {
            //Console.WriteLine("Your letter grade is F.");
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        // Core2
        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying. Next time would be better.");
        }

    }
}