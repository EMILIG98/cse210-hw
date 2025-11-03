using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();


            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }


            if (value == 0)
                break;

            numbers.Add(value);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        foreach (int n in numbers)
            sum += n;

        
        double average = (double)sum / numbers.Count;

        
        int largest = numbers[0];
        foreach (int n in numbers)
            if (n > largest)
                largest = n;

        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}






    
    
      
      


