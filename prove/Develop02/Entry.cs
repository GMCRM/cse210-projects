

//namespace helps to organize the code and helps to prevent naming conflicts with other classes.
namespace JournalProject
{
        class Entry
        {
        //I made the date `private set` because I don't want the user to change the date of an entry after it's created.
                public DateTime Date { get; private set;}

                public string Title { get; set; }
                public string Content { get; set; }
        //I created a constructor that takes a title and content as parameters and sets the date to the current date and time.
                public Entry(string title, string content)
                {
                Date = DateTime.Now;
                Title = title;
                Content = content;
                }
        //Im overriding the ToString method so that when I call Console.WriteLine(entry), it will display the date, title, and content of the entry.
                public override string ToString()
                {
                return $"{Date}|{Title}|{Content}";
                }

                public static Entry FromString(string str)
                {
                string[] parts = str.Split('|');
                if (parts.Length != 3)
                {
                        throw new FormatException("Invalid entry format");
                }

                Entry entry = new Entry(parts[1], parts[2]);
                entry.Date = DateTime.Parse(parts[0]);
                return entry;
                }
        }
}


