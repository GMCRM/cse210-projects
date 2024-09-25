using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptFavoriteNumber();

        int square = favoriteNumber * favoriteNumber;

        Console.WriteLine($"{userName}, the square of your number is {square}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine(); 
        return name; 
    }

    static int PromptFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine(); 
        int number;

        while (!int.TryParse(input, out number))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
            input = Console.ReadLine(); 
        }
        
        return number;
    }
}