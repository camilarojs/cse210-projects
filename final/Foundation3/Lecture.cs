using System;

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address, "Lecture")
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nEvent Type: {GetEventType()}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}