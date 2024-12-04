public class ScriptureReference
{
    // Attributes (private fields)
    private string _book;
    private int _chapter;
    private int _verse;

    // Constructor
    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Getter and Setter for Book
    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    // Getter and Setter for Chapter
    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    // Getter and Setter for Verse
    public int GetVerse()
    {
        return _verse;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    // Method to get reference
    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}