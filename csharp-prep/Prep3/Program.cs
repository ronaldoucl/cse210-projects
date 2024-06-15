using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0; 
        int numberOfGuesses = 0;
        string option = "";
        do {
            Console.WriteLine("What is the magic number?");
            int magicNumber = int.Parse(Console.ReadLine());
            while (guess != magicNumber) {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber) {
                    Console.WriteLine("Higher");
                } else if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine("You guessed it!");
            numberOfGuesses ++;
            
            Console.WriteLine("Do you want to play again? yes or no");
            option = Console.ReadLine();
        } while (option == "yes");

        Console.WriteLine("Number of Guesses: " + numberOfGuesses);
        Console.WriteLine("Thank you for playing!");
    }
}