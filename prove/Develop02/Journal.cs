using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    

    public void WriteNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.getRandomPrompt();
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

    public void SaveJournalToCsvFile()
    {
        Console.Write("Enter filename to save the journal (without extension): ");
        var filename = Console.ReadLine();
        using (var writer = new StreamWriter($"{filename}.csv"))
        {
            writer.WriteLine("Date,Prompt,Response");
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
        Console.WriteLine("Journal saved to CSV file.");
    }

    public void LoadJournalFromCsvFile()
    {
        Console.Write("Enter filename to load the journal (without extension): ");
        var filename = Console.ReadLine();
        if (File.Exists($"{filename}.csv"))
        {
            _entries.Clear();
            var lines = File.ReadAllLines($"{filename}.csv");
            for (var i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                var date = DateTime.Parse(fields[0]);
                var prompt = UnescapeFromCsv(fields[1]);
                var response = UnescapeFromCsv(fields[2]);
                var entry = new Entry(prompt, response, date);
                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded from CSV file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private static string UnescapeFromCsv(string field)
    {
        if (field.StartsWith("\"") && field.EndsWith("\""))
        {
            field = field.Substring(1, field.Length - 2).Replace("\"\"", "\"");
        }
        return field;
    }
}