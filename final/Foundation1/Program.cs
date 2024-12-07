using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listOfVideos = new List<Video>();    

        Comment comment1 = new Comment();
        comment1._name = "John Doe";
        comment1._text = "Great Informational video";

        Comment comment2 = new Comment();
        comment2._name = "Jane Doe";
        comment2._text = "This was informational and inspirational";

        Comment comment3 = new Comment();
        comment3._name = "Billy Bob";
        comment3._text = "You are great at making really helpful videos";

        Video video1 = new Video();
        video1._author = "John Smith";
        video1._title = "A very helpful, informational, and inspirational video";
        video1._length = "120";

        video1._Comments.Add(comment1);
        video1._Comments.Add(comment2);
        video1._Comments.Add(comment3);

        Comment comment4 = new Comment();
        comment4._name = "FortniteLover";
        comment4._text = "Your so good at fortnite";

        Comment comment5 = new Comment();
        comment5._name = "DonutLover1223";
        comment5._text = "*You're...... @FortniteLover";

        Comment comment6 = new Comment();
        comment6._name = "FortniteHATER27";
        comment6._text = "Fortnite sucks and I wish you didn't play it.";

        Video video2 = new Video();
        video2._author = "Ninja";
        video2._title = "The best Fortnite video out there";
        video2._length = "600";

        video2._Comments.Add(comment4);
        video2._Comments.Add(comment5);
        video2._Comments.Add(comment6);
        
        Comment comment7 = new Comment();
        comment7._name = "Sarah Smith";
        comment7._text = "Great message at this time of year!!";

        Comment comment8 = new Comment();
        comment8._name = "Ben Jones";
        comment8._text = "I need to share this with my friends, so powerful";

        Comment comment9 = new Comment();
        comment9._name = "Emma Johnson";
        comment9._text = "I am so grateful for Jesus Christ, He makes life possible.";

        Video video3 = new Video();
        video3._author = "Church Of Jesus Christ of Latter-day Saints";
        video3._title = "Jesus Christ is the reason for the season";
        video3._length = "90";

        video3._Comments.Add(comment7);
        video3._Comments.Add(comment8);
        video3._Comments.Add(comment9);

        listOfVideos.Add(video1);
        listOfVideos.Add(video2);
        listOfVideos.Add(video3);

        foreach (Video video in listOfVideos)
        {
            video.DisplayVideo();
        }
    }
}