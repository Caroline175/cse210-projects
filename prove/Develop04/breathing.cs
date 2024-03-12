class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner(3);

            Console.WriteLine("Breathe out...");
            PauseWithSpinner(3);
        }

        EndActivity();
    }
}