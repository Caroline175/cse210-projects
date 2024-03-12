using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. End");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            Activity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.PerformActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activity.PerformActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.PerformActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you!");
                    return;
                default:
                    Console.WriteLine("Please pick 1-4");
                    break;
            }
        }
    }
}