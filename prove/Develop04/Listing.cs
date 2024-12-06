using System;
using System.Threading;

public class Listing : Activity
{
    private string prompt;

    // Constructor that takes name and description, passes to base constructor
    public Listing(string name, string description, int duration, string listingPrompt)
        : base(name, description)
    {
        SetDuration(duration);
        prompt = listingPrompt;
    }

    // Method to get the prompt
    public string GetPrompt() => prompt;

    // Method to perform the listing activity
    public void StartListing()
    {
        Console.WriteLine($"Starting {GetName()}: {GetDescription()}");
        Console.WriteLine("Get ready to start listing your thoughts...");
        Thread.Sleep(2000); // Wait 2 seconds

        // Display a random prompt to the user
        Console.WriteLine($"Prompt: {GetPrompt()}");

        // Ask the user to list something (e.g., things they are grateful for)
        Console.WriteLine("How many items would you like to list?");
        int itemCount = int.Parse(Console.ReadLine());

        // Loop to get the list items
        for (int i = 0; i < itemCount; i++)
        {
            Console.WriteLine($"Please enter item #{i + 1}: ");
            string item = Console.ReadLine(); // Read the item from user
            Console.WriteLine($"Item #{i + 1}: {item}");
        }

        Console.WriteLine("Great job! You've completed the listing exercise.");
    }
}