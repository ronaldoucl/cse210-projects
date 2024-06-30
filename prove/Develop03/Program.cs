using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        ScriptureManager manager = new ScriptureManager();
        manager.Run();
    }  
}

/*Exceeding Requirements

Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.

I've created a new class that make easier the interaction with the user and that allows add more Scriptures*/