using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";  
        string message = "";
        string sign = "";

        Console.WriteLine("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90) {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80) {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70) {
            letter = "D";
        }
        else if (grade < 60) {
            letter = "F";
        }
        else {
            Console.WriteLine("Invalid Value");
        }

        if (letter != "F" && letter != "A") {
            int lastDigit = grade % 10;
            if (lastDigit >= 7) {
                sign = "+";
            } else if (lastDigit < 3) {
                sign = "-";
            }
        }

        if (grade >= 70) {
            message = "Congratulations! You passed the class.";
        }
        else if (grade < 70) {
            message = "Keep trying! You can do better next time.";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}. {message}");
    }
}