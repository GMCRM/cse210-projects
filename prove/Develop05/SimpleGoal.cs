public class SimpleGoal : Goal
{
    //constructor calling the base goal class constructor.
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }
    //Overriding the RecordEvent method to mark the goal as complete and give points
    public override void RecordEvent()
    {
        _isComplete = true; //marking goal as complete.
    }
}