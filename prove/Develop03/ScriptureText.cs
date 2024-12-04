using System;
using System.Collections.Generic;

public class ScriptureText
{
    // Attributes
    private string _verseText; // Backing field for VerseText
    private string[] _words;   // Store the current state of words
    private List<int> _hiddenIndices; // Tracks hidden word indices

    // Constructor
    public ScriptureText(string verseText)
    {
        _verseText = verseText;
        _words = verseText.Split(' ');  // Initialize the words array
        _hiddenIndices = new List<int>();
    }

    // Explicit getter and setter for VerseText
    public string GetVerseText()
    {
        return _verseText;
    }

    public void SetVerseText(string verseText)
    {
        _verseText = verseText;
        _words = verseText.Split(' '); // Reset the words array if text changes
        _hiddenIndices.Clear();        // Reset hidden indices
    }

    // Getter for WordList
    public string GetWordList()
    {
        return string.Join(" ", _words);
    }

    // Method to hide random words
    public string HideRandomWords(int numberOfWords)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(numberOfWords, _words.Length - _hiddenIndices.Count);

        while (_hiddenIndices.Count < _words.Length && wordsToHide > 0)
        {
            int index = random.Next(_words.Length);
            if (!_hiddenIndices.Contains(index))
            {
                _hiddenIndices.Add(index);
                _words[index] = new string('_', _words[index].Length);
                wordsToHide--;
            }
        }

        return GetWordList();
    }

    // Method to display current text
    public void DisplayCurrentText()
    {
        Console.WriteLine(GetWordList());
    }

    // Method to check if all words are hidden
    public bool IsFullyHidden()
    {
        return _hiddenIndices.Count == _words.Length;
    }
}