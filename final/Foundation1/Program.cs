using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        // Creating videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User A", "Great video!");
        video1.AddComment("User B", "I learned a lot from this.");
        video1.AddComment("User C", "I love it.");

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User D", "Nice content!");
        video2.AddComment("User E", "Could you explain this part more?");
        video2.AddComment("User F", "Amazing video!");

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User G", "Nice work!");
        video3.AddComment("User H", "Helpful information.");
        video3.AddComment("User I", "Share more!");

        // Adding videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying information for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine("=====================");
        }
    }
}



