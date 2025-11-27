using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity() :
        base("Listing Activity",
        "This activity helps you list the positive things in your life.")
    {}

    public void Run()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\nList as many responses as you can for the following prompt:");
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");

        Console.Write("\nYou may begin in: ");
        Countdown(5);

        List<string> items = new List<string>();
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMessage();
    }
}