//W02 Prove: Developer—Journal

/* Exceeding Requirements

Improve the process of saving and loading to save as a .csv file.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        while (true)
        {
            Console.WriteLine("\n\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Save the journal to a CSV file");
            Console.WriteLine("6. Load the journal from a CSV file");
            Console.WriteLine("7. Exit");
            Console.Write("What would you like to do: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveJournalToFile();
                    break;
                case 4:
                    journal.LoadJournalFromFile();
                    break;
                case 5:
                    journal.SaveJournalToCsvFile();
                    break;
                case 6:
                    journal.LoadJournalFromCsvFile();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}