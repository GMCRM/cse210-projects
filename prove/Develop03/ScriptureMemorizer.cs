using System;

public class ScriptureMemorizer
{
    // Attributes
    public ScriptureReference Reference { get; set; }
    public ScriptureText Text { get; set; }

    // Constructor
    public ScriptureMemorizer(ScriptureReference reference, ScriptureText text)
    {
        Reference = reference;
        Text = text;
    }

    // Method to start memorization
    public void StartMemorization()
    {
        while (!Text.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{Reference.GetReference()} - {Text.WordList}");
            Console.WriteLine("\nPress Enter to continue hiding more words.");
            Console.ReadLine();  // Just wait for Enter, ignore the input
            Text.HideRandomWords(3);
        }
        
        Console.Clear();
        Console.WriteLine($"{Reference.GetReference()} - {Text.WordList}");
        Console.WriteLine("\nAll words are hidden. Press Enter to end.");
        Console.ReadLine();
    }

    // Method to run the program
    public void Run()
    {
        StartMemorization();
    }
}