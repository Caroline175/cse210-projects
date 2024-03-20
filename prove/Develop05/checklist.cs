using System;

class ChecklistGoal : Goal
{
    private int TargetTimes;
    private int TimesCompleted;
    private int Points;
    private int Bonus;

    public ChecklistGoal(string name, int targetTimes, int points, int bonus) : base(name)
    {
        TargetTimes = targetTimes;
        TimesCompleted = 0;
        Points = points;
        Bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            TimesCompleted++;
            if (TimesCompleted == TargetTimes)
            {
                Completed = true;
                return Points + Bonus;
            }
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        string status = Completed ? "Completed" : $"Completed {TimesCompleted}/{TargetTimes} times";
        return $"{base.DisplayStatus()} - {status}";
    }
}
