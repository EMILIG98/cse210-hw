using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "How can this help you in the future?"
    };

    public ReflectingActivity() :
        base("Reflection Activity",
        "This activity helps you reflect on times you were strong and resilient.")
    {}

    public void Run()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nWhen you are ready, press Enter.");
        Console.ReadLine();

        Console.WriteLine("Now reflect on these questions:");
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            string q = _questions[rnd.Next(_questions.Count)];
            Console.Write($"> {q} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        EndMessage();
    }
}