using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber;
        
        do {
            Console.WriteLine("Enter a number: ");
            inputNumber = int.Parse(Console.ReadLine());
            numbers.Add(inputNumber);

        } while (inputNumber != 0);

        //Sum
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }

        //Average
        double average = sum / numbers.Count;

        //Maximum, or largest
        int maxNumber = 0;
        foreach (int number in numbers) {
            if (number > maxNumber) {
                maxNumber = number;
            }
        }

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + maxNumber);
    }
}