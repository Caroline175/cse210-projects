using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address = new Address
        {
            Street = "123 Main St",
            City = "New York",
            State = "NY",
            Country = "USA",
            PostalCode = "10001"
        };

        // Create events
        Event lecture = new Lecture("Tech Talk", "Learn about new technologies", DateTime.Now, "10:00 AM", address, "John Doe", 50);
        Event reception = new Reception("Networking Mixer", "Meet professionals from various industries", DateTime.Now, "6:00 PM", address, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy outdoor activities", DateTime.Now, "12:00 PM", address, "Sunny");

        // Generate and output marketing messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
