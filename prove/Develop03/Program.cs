
using System;

class Program
{
    static void Main(string[] args)
    {
        // Challenge: randomly select a scripture from a library.
        Random random = new Random();

        Reference[] references =
        {
            new Reference("John", 3, 16),
            new Reference("Proverbs", 3, 5, 6),
            new Reference("Psalm", 23, 1)
        };

        string[] scriptures =
        {
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life",
            "Trust in the Lord with all thine heart and lean not unto thine own understanding",
            "The Lord is my shepherd I shall not want"
        };

        int selection = random.Next(references.Length);

        Scripture scripture = new Scripture(
            references[selection],
            scriptures[selection]
        );

        string input = "";

        while (input != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input != "quit" && !scripture.AllWordsHidden())
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("Congratulations! You memorized the scripture!");
        }
    }
}
