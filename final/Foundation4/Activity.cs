public abstract class Activity
{
    // Private fields
    private DateTime date;
    private double durationInMinutes;

    // Constructor
    public Activity(DateTime date, double durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    // Getter methods
    public DateTime GetDate()
    {
        return date;
    }

    public double GetDurationInMinutes()
    {
        return durationInMinutes;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}