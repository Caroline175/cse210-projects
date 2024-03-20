using System;

abstract class Goal
{
    public string Name { get; set; }
    public bool Completed { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        Completed = false;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual string DisplayStatus()
    {
        string status = Completed ? "[X]" : "[ ]";
        return $"{status} {Name}";
    }
}
