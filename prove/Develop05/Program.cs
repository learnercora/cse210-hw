using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        List<Goals> goals = new List<Goals>();
      
        bool run = true;
        while (run != false)
        {
            //total points
            int totalScore = (goals.Count > 0) ?
                totalScore = goals[0].GetTotalScore() :
                0;
            // Console.WriteLine($"\nYou have {totalScore.ToString()} points\n");
            // menu
            string ans = menu.DisplayMenuAndAskBehavior(totalScore);
            if (ans == "1") //Create New Goals
            {
                string type = menu.DisplayTypeAndAskBehavior();
                if (type == "1") //SimpleGoal
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string shortDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointAmount = int.Parse(Console.ReadLine());
                    
                    goals.Add(new SimpleGoal(goalName,shortDescription,pointAmount,"[ ]",pointAmount));
                }
                else if (type == "2") //EternalGoal
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string shortDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointAmount = int.Parse(Console.ReadLine());

                    goals.Add(new EternalGoal(goalName,shortDescription,pointAmount,"[ ]",pointAmount));

                }
                else if (type == "3") //ChecklistGoal
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string shortDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointAmount = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal to be accomplished for a bonus? ");
                    int bounsTimes = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bounsAmount = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(goalName,shortDescription,pointAmount,bounsTimes,bounsAmount,0,"[ ]",pointAmount));

                }
                
            }
            else if (ans=="2") //List Goals
            { 
                if (goals.Count > 0)
                {
                    Console.WriteLine("The goals are:");
                    int itemNum = 1;
                    foreach (Goals goal in goals)
                    {
                        Console.Write($"{itemNum.ToString()}. ");
                        goal.displayGoalList(0);
                        itemNum ++;
                    }
                }
                else
                {
                    Console.WriteLine("There is no goal.");
                }
            }
            else if (ans=="3") //Save Goals
            {          
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"Score: {goals[0].GetTotalScore()}");
                    foreach (Goals goal in goals)
                    {
                        outputFile.WriteLine($"{goal.saveToFile()}");
                    }
                }
            }
            else if (ans=="4") //Load Goals
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                // goals.Clear(); // 清空现有的目标列表
                string[] lines = System.IO.File.ReadAllLines(filename);
                int total_score = 0;
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        if (line.StartsWith("SimpleGoal:"))
                        {
                            //Console.WriteLine(line);
                            string[] parts = line.Split(",");
                            string simpleGoal = parts[0].Split(":")[1].Trim();
                            string shortDescription = parts[1].Split(":")[1].Trim();
                            int point = int.Parse(parts[2].Split(":")[1].Trim());
                            string status = parts[3].Split(":")[1].Trim();
                            // Console.WriteLine(simpleGoal);
                            // Console.WriteLine(shortDescription);
                            // Console.WriteLine(point);
                            // Console.WriteLine(status);
                            goals.Add(new SimpleGoal(simpleGoal, shortDescription, point, status, point));
                        }
                        else if (line.StartsWith("EternalGoal:"))
                        {
                            //Console.WriteLine(line);
                            string[] parts = line.Split(",");
                            string eternalGoal = parts[0].Split(":")[1].Trim();
                            string shortDescription = parts[1].Split(":")[1].Trim();
                            int point = int.Parse(parts[2].Split(":")[1].Trim());
                            string status = parts[3].Split(":")[1].Trim();
                            goals.Add(new EternalGoal(eternalGoal, shortDescription, point, status, point));
                        }
                        else if (line.StartsWith("ChecklistGoal:"))
                        { 
                            string[] parts = line.Split(",");
                            string checklistGoal = parts[0].Split(":")[1].Trim();
                            string shortDescription = parts[1].Split(":")[1].Trim();
                            int point = int.Parse(parts[2].Split(":")[1].Trim());
                            string status = parts[3].Split(":")[1].Trim();
                            int bounsTimes = int.Parse(parts[4].Split(":")[1].Trim());
                            int bounsAmount = int.Parse(parts[5].Split(":")[1].Trim());
                            int completedTimes = int.Parse(parts[6].Split(":")[1].Trim());
                            goals.Add(new ChecklistGoal(checklistGoal,shortDescription,point,bounsTimes,bounsAmount,completedTimes,status,point));
                        }
                        if (line.StartsWith("Score:"))
                        {
                            string[] parts = line.Split(":");
                            total_score = int.Parse(parts[1].Trim());
                            // Console.WriteLine(total_score);
                        }
                    }
                }

                if (goals.Count > 0)
                {
                    goals[0].SetTotalScore(total_score);
                }
            }
            else if (ans=="5") //Record Event
            {
                if (goals.Count > 0)
                {
                    Console.WriteLine("The goals are:");
                    int itemNum = 1;
                    foreach (Goals goal in goals)
                    {
                        Console.Write($"{itemNum.ToString()}. ");
                        goal.displayGoalList(1);
                        itemNum ++;
                    }
                    Console.WriteLine("Which goal did you accomplish? ");
                    //
                    int goalItem = int.Parse(Console.ReadLine())-1;
                    goals[goalItem].recordEvent();
                    //找到目標分數
                    int itemScore = goals[goalItem].GetScore();
                    Console.WriteLine($"Congratulations! You have earned {itemScore.ToString()} points!");
                    //
                    goals[0].SetScore(itemScore);
                }
                else
                {
                    Console.WriteLine("There is no goal.");
                }
            }
            else if (ans=="6") //Quit
            {
                run = false;
            }
        }
    }
}