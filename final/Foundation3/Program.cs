using System;
class Program
{
    static void Main(string[] args)
    {

        Event lecture = new Lecture("Introduction to AI", "Learn about artificial intelligence", new DateTime(2024, 4, 10), new TimeSpan(14, 0, 0), 
                                    new Address("123 Main St", "Anytown", "CA", "12345"), "John Doe", 50);

        Event reception = new Reception("Networking Mixer", "An evening of networking and socializing", new DateTime(2024, 4, 15), new TimeSpan(18, 30, 0), 
                                        new Address("456 Elm St", "Othertown", "NY", "54321"), "rsvp@example.com");

        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Join us for a fun day outdoors", new DateTime(2024, 4, 20), new TimeSpan(12, 0, 0), 
                                                        new Address("789 Oak St", "Somewhere", "TX", "67890"), "Sunny with a high of 75°F");


        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception Marketing Messages:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Marketing Messages:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
