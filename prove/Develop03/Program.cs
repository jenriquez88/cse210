using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureHider
{
    public class Program
    {
        static void Main(string[] args)
        {
            var scripture = new Scripture("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                var input = Console.ReadLine();
                if (input == "quit")
                    break;

                scripture.HideRandomWords(3);

                if (scripture.IsCompletelyHidden())
                    break;
            }
        }
    }
}