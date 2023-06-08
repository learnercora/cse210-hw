using System;

public class BreathingActivity : Activity
{
    private int _breathingInSec;
    private int _breathingOutSec;
    

    public BreathingActivity()
        : base("Breathing")
    {
        _breathingInSec = 3;
        _breathingOutSec = 3;
    }
     public BreathingActivity(int breathingIn, int breathingOut)
        : base("Breathing")
    {
        _breathingInSec = breathingIn;
        _breathingOutSec = breathingOut;
    }

    public void DisplayBreathing(int durationSecond, int breathingInSec, int breathingOutSec)
    {   

        //Console.WriteLine(durationSecond);
        int totalSecond = 0;
        while (totalSecond < durationSecond)
        {
            Console.Write("\nBreathe in...");
            base.PauseCountdown(breathingInSec);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            base.PauseCountdown(breathingOutSec);
            Console.WriteLine();

            totalSecond += breathingInSec + breathingOutSec;
            //Console.WriteLine(totalSecond);
        }
        
    }

}