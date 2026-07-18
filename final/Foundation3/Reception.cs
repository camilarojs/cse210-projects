using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address, "Reception")
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nEvent Type: {GetEventType()}\nRSVP Email: {_rsvpEmail}";
    }
}