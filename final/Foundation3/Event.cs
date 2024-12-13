public class Event
{
    //attributes
    private string eventName;
    private string eventDate;
    private string eventTime;
    private Address eventAddress;


    //constructor
    public Event(string eventName, string eventDate, string eventTime, Address eventAddress)
    {
        this.eventName = eventName;
        this.eventDate = eventDate;
        this.eventTime = eventTime;
        this.eventAddress = eventAddress;
    }


    //Method gets standard tetails
    public virtual string GetStandardDetails()
    {
         return $"Event: {this.eventName}\nDate: {this.eventDate}\nTime: {this.eventTime}\nAddress:\n{this.eventAddress}";                               
    }
    // Method gets starndar details
     public virtual string GetFullDetails()
    {
        return GetStandardDetails(); 
    }
}
