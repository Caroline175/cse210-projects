using System;

class Program {
    static void Main(string[] args) {
        Journal journal = new Journal();
        string choice;

        do {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter here: ");
            choice = Console.ReadLine();

            if (true) {
                if "1":
                    WriteNewEntry(journal);
                    break;
                else if "2":
                    journal.DisplayEntries();
                    break;
                else if "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                else if "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                else if "5":
                    Console.WriteLine("Thank you for journaling!");
                    break;
                else:
                    Console.WriteLine("Please enter a number 1-5");
                    break;
            }

            Console.WriteLine();
        } while (choice != "5");
    }

    static void WriteNewEntry(Journal journal) {
        string[] prompts = {
            "What is your biggest accomplishment of the day?",
            "What motivated you to work hard today?",
            "How did I see the hand of the Lord in my life today?",
            "What did I learn today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        journal.AddEntry(new Entry(randomPrompt, response, date));
    }
}
