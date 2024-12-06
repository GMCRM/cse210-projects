using System;
using System.Threading;

public class Activity
{
    // Attributes
    private string name;
    private string description;
    private int duration; // In seconds

    // Constructor that accepts name, description, and duration
    public Activity(string activityName, string activityDescription)
    {
        name = activityName;
        description = activityDescription;
    }

    // Methods to get name, description, and duration
    public string GetName() => name;
    public string GetDescription() => description;
    public int GetDuration() => duration;

    // Method to set duration
    public void SetDuration(int activityDuration) => duration = activityDuration;

    // Method to start the activity with a timer
    public void StartActivity()
    {
        Console.WriteLine($"Starting {GetName()}: {GetDescription()}");

        // Ask the user for the duration of the activity
        Console.WriteLine("How many seconds would you like this activity to last?");
        SetDuration(int.Parse(Console.ReadLine())); // Set the duration from user input

        Console.WriteLine("Get ready...");

        // Start the timer countdown
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            // Calculate remaining time
            int remainingTime = (int)(endTime - DateTime.Now).TotalSeconds;
            Console.Clear();
            Console.WriteLine($"Time remaining: {remainingTime} seconds");
            Thread.Sleep(1000); // Update every second
        }

        Console.Clear();
        Console.WriteLine("Time's up! Activity completed.");
    }

    // Method to finish the activity
    public void FinishActivity()
    {
        Console.WriteLine($"You spent {GetDuration()} seconds on this activity.");
    }
}