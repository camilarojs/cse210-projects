using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _journalEntries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _journalEntries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('#');
            
            if (parts.Length >= 3)
            {
                JournalEntry loadedEntry = new JournalEntry();
                
                loadedEntry._date = parts[0];
                loadedEntry._prompt = parts[1];
                loadedEntry._response = parts[2];
                
                if (parts.Length == 4)
                {
                    loadedEntry._location = parts[3];
                }
                else
                {
                    loadedEntry._location = "Unknown";
                }

                _journalEntries.Add(loadedEntry);
            }
        }
    }
}