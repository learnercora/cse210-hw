using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        bool run = true;
        while (run != false)
        {
            //menu
            Menu menu = new Menu();
            menu.DisplayMenu();
            string ans = menu.AskBehavior();
            if (ans == "1") //Breathing
            {
                Activity Activity1 = new Activity("Breathing");
                Activity1.DisplayStartMessage();
                Activity1.AskDurationSecond();
                int second = Activity1.GetDurationSecond();
                Activity1.DisplayGetReady();
                
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayBreathing(second,4,6);

                Activity1.DisplayEndMessage(second);
            }
            else if (ans=="2") //Reflecting
            {
                Activity Activity2 = new Activity("Reflecting");
                Activity2.DisplayStartMessage();

                Activity2.AskDurationSecond();
                int second = Activity2.GetDurationSecond();
                Activity2.DisplayGetReady();
                
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayRandomPrompt();
                reflectingActivity.DisplayReflectQuestions(second);

                Activity2.DisplayEndMessage(second);
            }
            else if (ans=="3") //Listing
            {
                Activity Activity3 = new Activity("Listing");
                Activity3.DisplayStartMessage();

                Activity3.AskDurationSecond();
                int second = Activity3.GetDurationSecond();
                Activity3.DisplayGetReady();
                
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayRandomPrompt();
                listingActivity.ListItems(second);

                Activity3.DisplayEndMessage(second);
            }
            else if (ans=="4")
            {
                run = false;
            }
        }
    }
}