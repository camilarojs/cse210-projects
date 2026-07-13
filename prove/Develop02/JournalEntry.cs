using System;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _location;

    string[] _prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Length);
        _prompt = _prompts[index];

        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();

        Console.Write("Where are you writing from today? ");
        _location = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Response: {_response}\n");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}#{_location}";
    }
}