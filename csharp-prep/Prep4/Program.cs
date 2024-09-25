using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // Only add non-zero numbers
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Calculations
        int sum = 0;
        int largest = int.MinValue;

        foreach (int number in numbers)
        {
            sum += number; // Calculate sum
            if (number > largest) // Find largest number
            {
                largest = number;
            }
        }

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0; // Calculate average

        // Output results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}