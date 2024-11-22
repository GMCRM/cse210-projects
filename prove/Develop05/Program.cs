using System;

class Program
{
    static void Main(string[] args)
    {                                      //5 = points, 3 = completionTarget, 10 = bonusPoints
        var goal = new ChecklistGoal("Exercise", "Do 10 pushups daily", 5, 3, 10);
    
        Console.WriteLine("ChecklistGoal has been created!");

         // Complete the goal 3 times
        goal.RecordEvent(); // First completion
        Console.WriteLine($"Progress: {goal.GetProgress()}"); // Should be 1/3
        Console.WriteLine($"Points: {goal.GetPoints()}"); // Should be 5 points (base points)

        goal.RecordEvent(); // Second completion
        Console.WriteLine($"Progress: {goal.GetProgress()}"); // Should be 2/3
        Console.WriteLine($"Points: {goal.GetPoints()}"); // Should be 10 points (base points x2)

        goal.RecordEvent(); // Third completion (should trigger bonus points)
        Console.WriteLine($"Progress: {goal.GetProgress()}"); // Should be 3/3
        Console.WriteLine($"Points: {goal.GetPoints()}"); // Should be 20 points (base points x3 + bonus points)
    }
}