using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry journalEntry = new JournalEntry();
        myjournalEntry.CreateJournalEntry();
        // myjournalEntry.DisplayJournalEntry();
        // Console.WriteLine(myjournalEntry.CreateFileSystemString());
        JournalEntry myJournalEntry2 = new JournalEntry();
        myJournalEntry2.CreateJournalEntry();


        Journal myJournal = new Journal();
        myJournal.AddJournalEntry(myJournalEntry);
        myJournal.AddJournalEntry(myJournalEntry2);

        myJournal.DisplayJournal();
    }
}