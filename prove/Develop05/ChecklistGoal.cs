public class ChecklistGoal : Goal{
    private int _timesCompleted;
    private int _completionTarget;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int completionTarget, int bonusPoints) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _completionTarget = completionTarget;
        _bonusPoints = bonusPoints;
    }

public override void RecordEvent()
{
    // If already fully completed, prevent further recordings
    if (_isComplete)
    {
        Console.WriteLine($"Goal '{GetName()}' is complete! Congratulations on completing the checklist goal! Consider creating a new goal.");
        return;
    }

    _timesCompleted++; // Increment times completed
   
    if(_timesCompleted >= _completionTarget)
    {
        _isComplete = true;
    }
}

    // Return points based on times completed and bonus
    public override int GetPoints()
    {
        // Normal points for each completion
        int points = base.GetPoints();
        
        // If fully completed, add bonus points
        if (_timesCompleted == _completionTarget)
        {
            return points + _bonusPoints;
        }
        
        // Otherwise, just return points for current completion
        return points;
    }

    // Override GetDetails to include progress
    public override string GetDetails()
    {
        string completionStatus = _isComplete ? "[X]" : "[ ]";
        return $"{completionStatus} {GetName()} ({GetDescription()}) -- Currently {GetProgress()}";
    }

    // Method to display progress
    public string GetProgress()
    {
        return $"{_timesCompleted}/{_completionTarget} times completed";
    }
}