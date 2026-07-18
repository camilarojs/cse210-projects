using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Park Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 River Rd", "Boise", "ID", "USA");

        Lecture lecture = new Lecture("Intro to C#", "A beginner-friendly talk on C# basics.", "August 5, 2026", "6:00 PM", address1, "Dr. Sarah Chen", 150);

        Reception reception = new Reception("Company Gala", "An evening celebrating our 10th anniversary.", "September 12, 2026", "7:00 PM", address2, "rsvp@company.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A family-friendly outdoor picnic in the park.", "July 25, 2026", "12:00 PM", address3, "Sunny, 78°F");

        DisplayEventMessages(lecture.GetStandardDetails(), lecture.GetFullDetails(), lecture.GetShortDescription());
        DisplayEventMessages(reception.GetStandardDetails(), reception.GetFullDetails(), reception.GetShortDescription());
        DisplayEventMessages(outdoorGathering.GetStandardDetails(), outdoorGathering.GetFullDetails(), outdoorGathering.GetShortDescription());
    }

    static void DisplayEventMessages(string standardDetails, string fullDetails, string shortDescription)
    {
        Console.WriteLine("=== Standard Details ===");
        Console.WriteLine(standardDetails);
        Console.WriteLine();

        Console.WriteLine("=== Full Details ===");
        Console.WriteLine(fullDetails);
        Console.WriteLine();

        Console.WriteLine("=== Short Description ===");
        Console.WriteLine(shortDescription);
        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine();
    }
}