class Program
{
    static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5);
        ScriptureText text = new ScriptureText("Trust in the Lord with all your heart and lean not on your own understanding");
        ScriptureMemorizer memorizer = new ScriptureMemorizer(reference, text);
        memorizer.Run();
    }
}
