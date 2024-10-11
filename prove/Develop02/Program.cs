using System;
using System.IO;

namespace JournalProject {
    class Program
    {
 static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();


            // menu loop
            while (true)
            {
                Console.WriteLine("\n1. Add Entry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Save to File");
                Console.WriteLine("4. Load from File");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Today's prompt: {prompt}");
                        Console.Write("Enter the title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter your journal entry: ");
                        string content = Console.ReadLine();
                        Entry entry = new Entry(title, content);
                        journal.AddEntry(entry);
                        Console.WriteLine("Great Job! Your journal entry was added successfully.");
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter the filename to save your file: ");
                        string saveFilename = Console.ReadLine();
                            try{
                            journal.SaveToFile(saveFilename);
                            Console.WriteLine("Your journal entries have been saved successfully.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error saving the file: {ex.Message}");
                            }
                            break;
                    case "4":
                        Console.Write("Enter the filename to load: ");
                        string loadFilename = Console.ReadLine();
                        try{
                            journal.LoadFromFile(loadFilename);
                            Console.WriteLine("Your journal entries have been loaded successfully.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error loading the file: {ex.Message}");
                            }
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
