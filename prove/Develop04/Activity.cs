using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 15;
    }
    
    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
    }
    public void AskDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }
    
    public void InitActivity()
    {
        Console.Clear();
        ShowDetails();
        AskDuration();
        GetReady();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int totalSeconds)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;

        DateTime futureTime = GetFutureTime(totalSeconds);

        while(DateTime.Now < futureTime)
        {
            char[] spinChars = new char[]{'|','/','-','\\'};
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }

    public void ShowCountDown(int totalSeconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(totalSeconds - i);
            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
    }

    
    public DateTime GetFutureTime(int duration)
    {   
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName() {
        return _name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
}