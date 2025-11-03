using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        int percent = int.Parse(Console.ReadLine());

        string letter = "";
    

        if (percent >= 90)
        {
            letter = "A";

        }
        else if (percent >= 80)
        {
            letter = "B";

        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";

        }

        Console.WriteLine($"\nYour grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! Congratulations!! you are the best !!!");

        }
        else
        {
            Console.WriteLine("Better luck next time !!");

        }
    }

}
