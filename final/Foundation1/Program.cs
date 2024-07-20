using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("Top 10 Tech Gadgets of 2024", "TechGuru Neil", 720);

        Comment comment1 = new Comment("Alex", "Absolutely need to get my hands on the number one gadget!");
        Comment comment2 = new Comment("Samantha", "Very informative, thanks for breaking down the specs.");
        Comment comment3 = new Comment("Jordan", "Can you review budget-friendly alternatives too?");

        video1.ListComment(comment1);
        video1.ListComment(comment2);
        video1.ListComment(comment3);

        videosList.Add(video1);

        Video video2 = new Video("Yoga for Beginners: A 30-Day Challenge", "YogaWithAmanda", 1800);

        Comment video2Comment1 = new Comment("Bella", "Day 5 and I’m already feeling more flexible!");
        Comment video2Comment2 = new Comment("Mark", "Thanks, Amanda! Your instructions are so clear and calming.");
        Comment video2Comment3 = new Comment("Lina", "Loving this challenge! Can you make more videos for advanced poses?");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        Video video3 = new Video("Quick and Easy Vegan Meals under 20 Minutes!", "Chef Joey", 540);

        Comment video3Comment1 = new Comment("Casey", "Tried the lentil tacos and they were a hit at my house!");
        Comment video3Comment2 = new Comment("Taylor", "Finally, some vegan recipes that don't take forever to make.");
        Comment video3Comment3 = new Comment("Drew", "These meals are perfect for my busy schedule, thanks!");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
