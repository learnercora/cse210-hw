using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Program 4: Polymorphism with Exercise Tracking");
        //https://byui-cse.github.io/cse210-course-2023/unit06/project-plan.html

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running( 5.6, "03 Nov 2022", 30));
        activities.Add(new Cycling( 29.6, "15 Dec 2022", 45));
        activities.Add(new Swimming( 30, "08 Feb 2023", 40));

        // Get a custom calculation for each one
        foreach(Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine($"{summary}");
        }
    }
}