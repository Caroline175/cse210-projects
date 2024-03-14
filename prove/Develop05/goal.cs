{
    public string Name 
    public int Value 
    public bool Completed 

    public abstract void Display();

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public virtual void RecordEvent()
    {
        Completed = true;
    }
}