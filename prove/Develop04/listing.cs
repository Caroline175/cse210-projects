using System;

class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have several seconds to think about the prompt and list as many items as you can.");

        PauseWithSpinner(Duration);

        Console.WriteLine($"You listed {random.Next(5, 15)} items.");

        EndActivity();
    }
}