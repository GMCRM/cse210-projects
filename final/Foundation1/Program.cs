class Program
{
    static void Main(string[] args)
    {
        // List to store video objects
        List<Video> videos = new List<Video>();

        // Create video objects
        Video video1 = new Video("Video 1", "Author 1", 60);
        Video video2 = new Video("Video 2", "Author 2", 120);
        Video video3 = new Video("Video 3", "Author 3", 180);

        // Add video objects to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Output confirmation
        Console.WriteLine("Videos added to list");

        // Adding comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "This really helped me."));
        video1.AddComment(new Comment("Charlie", "Clear and concise!"));

        // Adding comments to video2
        video2.AddComment(new Comment("Daisy", "Nice tips, thanks!"));
        video2.AddComment(new Comment("Eve", "Could you do a part 2?"));
        video2.AddComment(new Comment("Frank", "Very helpful!"));

        // Adding comments to video3
        video3.AddComment(new Comment("Grace", "Fun examples, well done!"));
        video3.AddComment(new Comment("Hank", "Algorithms are so cool."));
        video3.AddComment(new Comment("Ivy", "This video is awesome!"));

        // Output confirmation
        Console.WriteLine("Comments added to list");

        foreach (Video video in videos)
        {
            // Display video details
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            // Display comments using correct method names
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine(); // Empty line for better formatting
        }
    }
}