using System;

class Program
{
    static void Main()
    {
        // Create an Address object
        Address eventAddress = new Address("123 Main St", "Springfield", "IL", "USA");

        // Create a Lecture event
        Lecture lectureEvent = new Lecture("Tech Conference", "A conference about tech.", "December 20, 2024", "10:00 AM", eventAddress, "John Doe", 100);
        Console.WriteLine("Lecture Event - Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Lecture Event - Full Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();

        // Create a Reception event (corrected to match the constructor)
        Reception receptionEvent = new Reception("Wedding Reception", "December 20, 2024", "6:00 PM", eventAddress, "rsvp@example.com");
        Console.WriteLine("Reception Event - Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Event - Full Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();

        // Create an Outdoor event
        Outdoor outdoorEvent = new Outdoor("Outdoor Concert", "A live concert in the park.", "December 21, 2024", "5:00 PM", eventAddress, "Clear Skies");
        Console.WriteLine("Outdoor Event - Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Event - Full Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
    }
}