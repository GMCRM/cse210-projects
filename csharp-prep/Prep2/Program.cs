using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string letterGrade;
        if (gradeInt >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You got a {letterGrade}.");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Great Job! you passed!");
        }
        else{
            Console.WriteLine("You failed, better luck next time!");
        }
    }
}