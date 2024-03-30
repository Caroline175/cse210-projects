using System;
class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("User3", "Nice content!");
        video2.AddComment("User4", "Could be better.");
        videos.Add(video2);

        Video video3 = new Video("Title 3", "Author 3", 150);
        video3.AddComment("User5", "Very informative.");
        video3.AddComment("User6", "Liked it!");
        videos.Add(video3);

        // Displaying videos and comments
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("----------");
                Console.WriteLine("Comment by: " + comment.CommenterName);
                Console.WriteLine("Text: " + comment.CommentText);
            }
            Console.WriteLine("====================");
        }
    }
}
