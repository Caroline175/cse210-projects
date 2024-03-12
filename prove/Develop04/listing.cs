using System;

class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are your role models?",
        "Where are places you would like to travel to?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What attributes would you like to develop?"
    };

    public ListingActivity() : base("Listing", "List as many things as you can to reflect on the good.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Think of as many items as you can!.");

        PauseWithSpinner(Duration);

        Console.WriteLine($"You listed {random.Next(5, 15)} items.");

        EndActivity();
    }
}