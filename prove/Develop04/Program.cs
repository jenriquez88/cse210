using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 
            new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult." },
            new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?" });
        ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?" });

        Console.Clear();
        Console.WriteLine("Welcome to the mindfullness app");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflecting");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");
        Console.WriteLine("");
        Console.Write("Write the number of the activity:");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathingActivity.Run();
                break;
            case 2:
                reflectingActivity.Run();
                break;
            case 3:
                listingActivity.Run();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}