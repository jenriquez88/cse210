using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 150)
        };

        videos[0].AddComment("John", "Great video!");
        videos[0].AddComment("Alice", "I learned a lot from this.");
        videos[0].AddComment("Bob", "Could be better.");

        videos[1].AddComment("Emily", "Nice content!");
        videos[1].AddComment("David", "Very informative.");

        videos[2].AddComment("Sophia", "This video changed my perspective.");
        videos[2].AddComment("Michael", "Well done!");

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}