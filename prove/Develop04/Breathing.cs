using System;
using System.Threading;

public class Breathing : Activity
{
    // Constructor that takes name and description, passes to base constructor
    public Breathing(string name, string description)
        : base(name, description)
    {
    }

    // Method to perform the breathing exercise
    public void StartBreathing()
    {
        Console.WriteLine($"Starting {GetName()}: {GetDescription()}");
        Console.WriteLine("Get ready to start the breathing exercise...");

        // Start the timer
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000); // Breathe in for 4 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000); // Breathe out for 4 seconds
        }

        Console.Clear();
        Console.WriteLine("Great job! You've completed the breathing exercise.");
    }
}