using System;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nEvent Type: {GetEventType()}\nWeather Forecast: {_weatherForecast}";
    }
}