

public class Lecture : Event
{
//attributes
// speaker, capacity
    private string speaker;
    private int capacity;

//constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
    : base(title, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    //method for full details specific to lecture....
    public string GetFullDetails()
    {
        return GetStandardDetails() +
               $"\nSpeaker: {speaker}\nCapacity: {capacity} attendees";
    }


}