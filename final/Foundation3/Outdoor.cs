public class Outdoor : Event
{
    // attributes
    private string weather;

    // constructor
    public Outdoor(string title, string description, string date, string time, Address address, string weather)
        : base(title, date, time, address)
    {
        this.weather = weather;
    }

    // method for full details for outdoor event
    public override string GetFullDetails()
    {
        return GetStandardDetails() +
               $"\nWeather Forecast: {weather}";
    }


}