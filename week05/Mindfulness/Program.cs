using System;

class Program
{
    static void Main(string[] args)
    {
       int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
            }
            else if (choice == 3)
            {
                ListingActivity l = new ListingActivity();
                l.Run();
            }
        }
    }
}
    
