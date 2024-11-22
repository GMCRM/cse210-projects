public class ChecklistGoal : Goal{

    private int _timesCompleted; //number of times the goal has been completed.
    private int _completionTarget; //number of times the goal must be completed to be marked as complete.
    private int _bonusPoints; //points awarded for completing the goal.


    //constructor calling the base goal class constructor.
    public ChecklistGoal(string name, string description, int points, int completionTarget, int bonusPoints) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _completionTarget = completionTarget;
        _bonusPoints = bonusPoints;
    }



    //Overriding the RecordEvent method to mark the goal as complete and give points
    public override void RecordEvent()
    {
       _timesCompleted++; //incrementing the number of times the goal has been completed.
       _points += GetPoints();//Add the base points for every completion
       
    if(_timesCompleted >= _completionTarget)
    {
        _isComplete = true; // Mark goal as complete when target is reached
        _points += _bonusPoints; //add bonus points to user score when goal is completed.
    }
}
  // Override GetPoints to return total points instead of base points
    public override int GetPoints()
    {
        return _points;
    }

// Method to display progress
    public string GetProgress()
    {
        return $"{_timesCompleted}/{_completionTarget} times completed";
    }
}