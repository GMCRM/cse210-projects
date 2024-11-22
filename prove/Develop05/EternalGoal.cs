public class EternalGoal : Goal{
    //constructor calling the base goal class constructor.

    private int _totalPoints; //tracking total points.
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _totalPoints = 0;
    }
    //Overriding the RecordEvent method to mark the goal as complete and give points
    public override void RecordEvent()
    {
       //add points to user score each time goal recorded
       //no completion, just total points.
       _points += GetPoints();
    }

    // Override GetPoints to return total points instead of base points
    public override int GetPoints()
    {
        return _totalPoints;
    }
}