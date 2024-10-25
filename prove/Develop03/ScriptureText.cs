using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureText
{
    // Attributes
    public string VerseText { get; set; }
    private string[] words;  // Store the current state of words
    private List<int> hiddenIndices;

    public string WordList 
    { 
        get { return string.Join(" ", words); }
    }

    // Constructor
    public ScriptureText(string verseText)
    {
        VerseText = verseText;
        words = verseText.Split(' ');  // Initialize the words array
        hiddenIndices = new List<int>();
    }

    // Method to hide random words
    public string HideRandomWords(int numberOfWords)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(numberOfWords, words.Length - hiddenIndices.Count);

        while (hiddenIndices.Count < words.Length && wordsToHide > 0)
        {
            int index = random.Next(words.Length);
            if (!hiddenIndices.Contains(index))
            {
                hiddenIndices.Add(index);
                words[index] = new string('_', words[index].Length);
                wordsToHide--;
            }
        }

        return WordList;
    }

    // Method to display current text
    public void DisplayCurrentText()
    {
        Console.WriteLine(WordList);
    }

    // Method to check if all words are hidden
    public bool IsFullyHidden()
    {
        return hiddenIndices.Count == words.Length;
    }
}