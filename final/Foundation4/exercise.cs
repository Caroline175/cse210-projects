using System;
using System.Collections.Generic;

class Exercise
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Add some activities
        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("05 Nov 2022", 45, 20));
        activities.Add(new Swimming("07 Nov 2022", 60, 10));

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
