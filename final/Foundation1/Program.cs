using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> monitoredVideos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1._title = "Day in the Life of a Software Engineer at Pinterest";
        video1._author = "DevCamila";
        video1._lengthInSeconds = 540;

        Comment comment1 = new Comment(); 
        comment1._commenterName = "Linling"; 
        comment1._commentText = "What laptop is that on your desk?";
        video1._comments.Add(comment1);

        Comment comment2 = new Comment(); 
        comment2._commenterName = "Bianca"; 
        comment2._commentText = "Nice keyboard setup!";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment(); 
        comment3._commenterName = "CharliePuth"; 
        comment3._commentText = "The quality on that laptop looks amazing";
        video1._comments.Add(comment3);

        Comment comment4 = new Comment(); 
        comment4._commenterName = "Diana"; 
        comment4._commentText = "Loved the aesthetic of this video.";
        video1._comments.Add(comment4);

        monitoredVideos.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2._title = "Ultimate Backyard BBQ Cooking Tutorial";
        video2._author = "GrillMasterCamila";
        video2._lengthInSeconds = 720;

        Comment comment5 = new Comment(); 
        comment5._commenterName = "Ethan"; 
        comment5._commentText = "Are you drinking Cherry Dr Pepper? That flavor is the best.";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment(); 
        comment6._commenterName = "Mike"; 
        comment6._commentText = "Definitely trying this recipe next weekend.";
        video2._comments.Add(comment6);

        Comment comment7 = new Comment(); 
        comment7._commenterName = "GeorgeW"; 
        comment7._commentText = "I spotted the Dr Pepper on the table, good choice.";
        video2._comments.Add(comment7);

        Comment comment8 = new Comment(); 
        comment8._commenterName = "Hannah"; 
        comment8._commentText = "Can you do a video on chicken wings next?";
        video2._comments.Add(comment8);

        monitoredVideos.Add(video2);

        // Video 3
        Video video3 = new Video();
        video3._title = "How I Trained for a Half Marathon in 3 Months";
        video3._author = "RunWithSarah";
        video3._lengthInSeconds = 610;

        Comment comment9 = new Comment(); 
        comment9._commenterName = "Ian"; 
        comment9._commentText = "Is that the new Apple watch you are using to track miles?";
        video3._comments.Add(comment9);

        Comment comment10 = new Comment(); 
        comment10._commenterName = "Julia"; 
        comment10._commentText = "So inspiring, I want to start running too.";
        video3._comments.Add(comment10);

        Comment comment11 = new Comment(); 
        comment11._commenterName = "Kevin"; 
        comment11._commentText = "How is the battery life on that smartwatch?";
        video3._comments.Add(comment11);

        Comment comment12 = new Comment(); 
        comment12._commenterName = "Laura"; 
        comment12._commentText = "Great tips on the running strategy!";
        video3._comments.Add(comment12);

        monitoredVideos.Add(video3);

        Console.WriteLine("--- PRODUCT AWARENESS MONITORING REPORT ---\n");
        
        foreach (Video video in monitoredVideos)
        {
            video.DisplayVideoDetails();
        }
    }
}