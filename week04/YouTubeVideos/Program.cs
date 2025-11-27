using System;
using System.Runtime.Intrinsics;

class Program
{
    static void Main(string[] args)
    {
      List<Video> videos = new List<Video>();

      Video v1= new Video("Learn C#","Emilio Garcia",300);
      v1.AddComment(new Comment("Ana","Great explanation"));
      v1.AddComment(new Comment("Ana","Great explanation"));
      v1.AddComment(new Comment("Ana","Great explanation"));
      videos.Add(v1);

      Video v2 = new Video("Car Review: Toyota Corolla","Experto en Autos", 420);
      v2.AddComment(new Comment("Ana","Great explanation"));
      v2.AddComment(new Comment("Ana","Great explanation"));
      v2.AddComment(new Comment("Ana","Great explanation"));
      videos.Add(v2);

      Video v3 = new Video("How to Sell More","Emilio Sales", 250);
      v3.AddComment(new Comment("Ana","Great explanation"));
      v3.AddComment(new Comment("Ana","Great explanation"));
      v3.AddComment(new Comment("Ana","Great explanation"));
      videos.Add(v3);


      foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
        

      foreach (Comment c in video.GetComments())
        {
            Console.WriteLine($"{c.Name}: {c.Text}");

        }

        Console.WriteLine("______________________________________");
    }
}
}



