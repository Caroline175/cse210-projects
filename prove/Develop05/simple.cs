using System;

class SimpleGoal : Goal
{
    private int Points;

    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }
}
