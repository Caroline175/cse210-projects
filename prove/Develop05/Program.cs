class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save and Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                if "1":
                    goalManager.AddGoal();
                    break;
                else if "2":
                    goalManager.RecordEvent();
                    break;
                else if "3":
                    goalManager.DisplayGoals();
                    break;
                else if "4":
                    goalManager.DisplayScore();
                    break;
                else if "5":
                    goalManager.SaveGoalsAndScores();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please pick a number 1-5.");
                    break;
            }
        }
    }
}
