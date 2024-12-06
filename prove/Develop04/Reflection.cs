using System;
using System.Threading;

public class Reflection : Activity
{
    private string prompt;

    // Constructor that takes name and description
    public Reflection(string name, string description)
        : base(name, description)
    {
    }

    // Method to get the prompt
    public string GetPrompt() => prompt;

    // Method to set the prompt
    public void SetPrompt(string newPrompt) => prompt = newPrompt;

    // Method to perform the reflection activity
    public void StartReflection()
    {
        // Use the base class method to set duration
        StartActivity();

        Console.Clear();
        Console.WriteLine($"Starting {GetName()}: {GetDescription()}");
        Console.WriteLine("Get ready to start your reflection...");
        Thread.Sleep(2000); // Wait 2 seconds

        // Display the prompt
        Console.WriteLine($"Prompt: {GetPrompt()}");
        Console.WriteLine("Take a moment to think about this.");
        Thread.Sleep(5000);

        // Start the timer
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Continue reflecting...");
            Thread.Sleep(5000); // Pause for reflection
        }

        Console.Clear();
        Console.WriteLine("Great job! You've completed the reflection exercise.");
    }
}