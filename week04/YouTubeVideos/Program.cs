using System;
using System.Collections.Generic;

class YouTubeVideo
{
    public string Title { get; set; }
    public string Channel { get; set; }
    public int Views { get; set; }

    public YouTubeVideo(string title, string channel, int views)
    {
        Title = title;
        Channel = channel;
        Views = views;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Channel: {Channel}");
        Console.WriteLine($"Views: {Views}");
        Console.WriteLine("------------------------------");
    }
}

class Program
{
    static void Main()
    {
        List<YouTubeVideo> videos = new List<YouTubeVideo>
        {
            new YouTubeVideo("Learning C#", "Code Academy", 15000),
            new YouTubeVideo("Building a .NET App", "Dev Insights", 8000),
            new YouTubeVideo("Advanced C# Techniques", "Programming Pro", 12000)
        };

        Console.WriteLine("YouTube Videos List:");
        Console.WriteLine("=====================");

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}