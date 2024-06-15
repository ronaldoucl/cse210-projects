using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.WriteLine("Please enter your name:");
        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        Console.WriteLine("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number) {
        return number * number;
    }     

    static void DisplayResult(string name, int squaredNumber) {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }       
}