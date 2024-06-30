using System;
using System.Collections.Generic;

public class ScriptureManager
{
    private List<Scripture> _listScriptures;

    public ScriptureManager()
    {
        _listScriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Alma", 7, 11, 13), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.\n\nAnd he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.\n\nNow the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.")
        };
    }

    public void Run()
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("Select one of the Scriptures:");
            for (int i = 0; i < _listScriptures.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + _listScriptures[i].GetReference());
            }

            int option = Int32.Parse(Console.ReadLine());
            MemorizeScripture(_listScriptures[option - 1]);

            Console.WriteLine("Press enter to continue practicing or type 'exit' to finish");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                keepPlaying = false;
        }
    }

    private void MemorizeScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
        if (scripture.IsCompletelyHidden()) {
            Console.WriteLine("Congrats! You have memorized the Scripture.");
        }
    }

    private void AddScripture(Scripture scripture) {
        _listScriptures.Add(scripture);
    }
}
