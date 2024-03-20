using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();

        SimpleGoal marathonGoal = new SimpleGoal("Enter a simple goal", 5);
        EternalGoal scriptureGoal = new EternalGoal("Enter an Eternal goal", 10);
        ChecklistGoal templeGoal = new ChecklistGoal("Enter a Checklist goal");
        
        tracker.AddGoal(marathonGoal);
        tracker.AddGoal(scriptureGoal);
        tracker.AddGoal(templeGoal);

        tracker.DisplayGoals();
        tracker.DisplayScore();

        tracker.SaveGoals("goals_data.dat");

        tracker = null;

        GoalTracker newTracker = new GoalTracker();
        newTracker.LoadGoals("goals_data.dat");


        newTracker.DisplayGoals();
        newTracker.DisplayScore();
    }
}

