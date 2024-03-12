using System;

abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} Activity:");
        Console.WriteLine(Description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Well done! You completed {Name} Activity!");
        PauseWithSpinner(3);
    }

    protected void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        Duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity();
}

