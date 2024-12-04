using System;

public class ScriptureMemorizer
{
    // Attributes
    private ScriptureReference _reference; // Backing field for Reference
    private ScriptureText _text;          // Backing field for Text

    // Constructor
    public ScriptureMemorizer(ScriptureReference reference, ScriptureText text)
    {
        _reference = reference;
        _text = text;
    }

    // Getter and Setter for Reference
    public ScriptureReference GetReference()
    {
        return _reference;
    }

    public void SetReference(ScriptureReference reference)
    {
        _reference = reference;
    }

    // Getter and Setter for Text
    public ScriptureText GetText()
    {
        return _text;
    }

    public void SetText(ScriptureText text)
    {
        _text = text;
    }

    // Method to start memorization
    public void StartMemorization()
    {
        while (!_text.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{_reference.GetReference()} - {_text.GetWordList()}");
            Console.WriteLine("\nPress Enter to continue hiding more words.");
            Console.ReadLine(); // Just wait for Enter, ignore the input
            _text.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine($"{_reference.GetReference()} - {_text.GetWordList()}");
        Console.WriteLine("\nAll words are hidden. Press Enter to end.");
        Console.ReadLine();
    }

    // Method to run the program
    public void Run()
    {
        StartMemorization();
    }
}