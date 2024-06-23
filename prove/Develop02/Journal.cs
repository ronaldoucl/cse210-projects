using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private static readonly List<string> Prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me feel grateful today?",
        "What was the biggest challenge I faced today?"
    };

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response, DateTime.Now);
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._response);
                writer.WriteLine("---");
            }
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            _entries.Clear();
            var lines = File.ReadAllLines(filename);
            for (var i = 0; i < lines.Length; i += 4)
            {
                var date = DateTime.Parse(lines[i]);
                string prompt = lines[i + 1];
                string response = lines[i + 2];
                var entry = new Entry(prompt, response, date);
                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}