public class Cycling : Activity
{
    private double distance; // in miles

    // Constructor
    public Cycling(DateTime date, double durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / GetDurationInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetDurationInMinutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetDurationInMinutes()} min) - Distance {distance} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}