public class ScriptureReference
{
    // Attributes
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }

    // Constructor
    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    // Method to get reference
    public string GetReference()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}
