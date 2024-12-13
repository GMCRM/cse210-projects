public class Reception : Event
{
    // attribute specific to Reception
    private string rsvpEmail;

    //constructor
    public Reception(string eventName, string eventDate, string eventTime, Address eventAddress, string rsvpEmail)
        : base(eventName, eventDate, eventTime, eventAddress)
    {
        this.rsvpEmail = rsvpEmail;
    }

    //Method details for Reception
    public override string GetFullDetails()
    {
        return base.GetFullDetails() +
        $"\nRSVP Email: {this.rsvpEmail}";
    }


}
