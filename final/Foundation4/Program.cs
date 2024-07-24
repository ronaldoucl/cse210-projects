using System;

class Program
{
    static void Main(string[] args)
    {
        /*List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 40, 22),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }*/
        List<Activity> activities = new List<Activity>();
        Console.WriteLine("Enter data for 3 activities.");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Activity {i + 1} Type (Running, Cycling, Swimming):");
            string type = Console.ReadLine().Trim();

            Console.WriteLine("Enter duration in minutes:");
            int duration = int.Parse(Console.ReadLine());

            if (type.Equals("Running", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter distance in kilometers:");
                double distance = double.Parse(Console.ReadLine());
                activities.Add(new Running(duration, distance));
            }
            else if (type.Equals("Cycling", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter speed in kilometers per hour:");
                double speed = double.Parse(Console.ReadLine());
                activities.Add(new Cycling(duration, speed));
            }
            else if (type.Equals("Swimming", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter number of laps:");
                int laps = int.Parse(Console.ReadLine());
                activities.Add(new Swimming(duration, laps));
            }
            else
            {
                Console.WriteLine("Invalid activity type.");
                i--; 
            }
        }

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}