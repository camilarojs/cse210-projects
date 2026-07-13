using System;

// Creativity Description:
// I added a location question to the journal entries.
// The program asks the user where they are writing from, saves it, and displays it.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                JournalEntry entry = new JournalEntry();
                entry.CreateJournalEntry();
                myJournal.AddJournalEntry(entry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
        }
    }
}