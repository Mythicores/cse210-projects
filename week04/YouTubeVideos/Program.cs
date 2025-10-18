using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();
        Video mrBeast = new Video("I fed 1 million people!", "Mr. Beast", 60);
        videos.Add(mrBeast);
        Video markiplier = new Video("I played Hollow Knight.", "Markiplier", 600);
        videos.Add(markiplier);
        Video pewdiepie = new Video("I installed Linux, and so should you...", "PewdiePie", 1000);
        videos.Add(pewdiepie);

        AddComments(mrBeast, "Mythicore", "I love this video!", 3);
        AddComments(markiplier, "Legender", "Absolute best game out there.", 3);
        AddComments(pewdiepie, "Fantastical", "I'm installing Linux right now", 3);
        foreach(Video video in videos)
        {
            video.Display(video);
        }

        mrBeast.DisplayAllComments();
        pewdiepie.DisplayAllComments();
        markiplier.DisplayAllComments();


    }
    static void AddComments(Video video, string name, string comment, int repeat)
    {
        for (int i = 0; i < repeat; i++)
        {
            video.AddComment(name, comment);
        }
    }
}