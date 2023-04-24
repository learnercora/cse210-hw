using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        
        int number = -1;
        List<int> numbers = new List<int>();
        double sum = 0;
        double average = 0;
        int largest_num = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;

                largest_num = numbers[0];
                if (number > largest_num)
                {
                    largest_num = number;
                }
            }
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest_num}");
        
    }
}