using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("GOOD LUCK!!");
        Console.WriteLine(_description);

        Console.WriteLine("\n How long, in seconds, would you like this session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\n Get ready!!!....");
        ShowSpinner(3);

    }

    public void EndMessage()
    {
        Console.WriteLine("\n Well done!!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        
    }

    protected int GetDuration()
    {
        return _duration;

    }
    protected void ShowSpinner(int seconds)
    {
        string[] spin = {"|","/","-","\\"};
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spin[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1 ) % 4;
        }
    }
    protected void Countdown(int seconds)

    {
      
        for (int i = seconds; i >= 1; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
    }
     

}