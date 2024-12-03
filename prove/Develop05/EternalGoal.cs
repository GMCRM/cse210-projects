public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // No need to track total points in this class
    }
    
    // Simply call the base method
    public override void RecordEvent()
    {
        // No need to track points within the goal itself
    }

    // Return the base points each time
    public override int GetPoints()
    {
        return base.GetPoints(); // Always return the base points
    }
}