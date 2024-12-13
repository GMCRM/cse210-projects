public class Swimming : Activity
{
    private double distance; // in meters

    // Constructor
    public Swimming(DateTime date, double durationInMinutes, double distance)
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
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetDurationInMinutes()} min) - Distance {distance} meters, Speed {GetSpeed():0.0} m/min, Pace: {GetPace():0.0} min per meter";
    }
}