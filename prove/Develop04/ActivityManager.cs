using System;
using System.IO;

public class ActivityManager
{
    public void Start()
    {
        string input = "";

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.InitActivity();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                    AddLog(breathingActivity.GetDuration(), breathingActivity.GetName());
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.InitActivity();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                    AddLog(reflectingActivity.GetDuration(), reflectingActivity.GetName());
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.InitActivity();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    AddLog(listingActivity.GetDuration(), listingActivity.GetName());
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter the number of the menu option.");
                    break;
            }
        }
        Environment.Exit(0);
    }

    public void AddLog(int duration, string name)
    {
        string logFilePath = "ActivityLog.log";
        string logMessage = $"Activity: {name}, Duration: {duration}, Timestamp: {DateTime.Now}";
        
        using (StreamWriter sw = new StreamWriter(logFilePath, true))
        {
            sw.WriteLine(logMessage);
        }
    }
}
