public abstract class Goal
{ 
    //Attributes
    private string _name;
    private string _description;
    protected int _points;
    protected bool _isComplete;

    // constructors
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false; //goal starts as incomplete
    }

    //methods

    public virtual string GetDetails()
{
    string completionStatus = _isComplete ? "[X]" : "[ ]";
    return $"{completionStatus} {_name} ({_description})";
}
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    //virtual methed that will be overriden by child classes
    public virtual void RecordEvent()
    {
        //placeholder code. will be difined in child classes.
    }
}