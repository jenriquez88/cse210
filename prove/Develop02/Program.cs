using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    
                    Console.Write("Enter your response: ");
                    string entryText = Console.ReadLine();
                    
                    Entry newEntry = new Entry(prompt, entryText);
                    journal.AddEntry(newEntry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case 4:
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}