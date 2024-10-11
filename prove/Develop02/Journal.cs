using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProject
{
    class Journal
        {
            private List<Entry> entries = new List<Entry>();

            public void AddEntry(Entry entry)
            {
                entries.Add(entry);
            }

            public void DisplayEntries()
            {
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry.ToString());
                }
            }

            public void SaveToFile(string filename)
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine(entry.ToString());
                    }
                }
            }

            public void LoadFromFile(string filename)
            {
                entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
               
                        entries.Add(Entry.FromString(line));
                    }
                }
        }
    }
}

