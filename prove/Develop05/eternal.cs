using System;

class EternalGoal : Goal
{
    private int Points;

    public EternalGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override int RecordEvent()
    {
        return Points;
    }
}
