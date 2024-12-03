using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _totalScore = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nGoal Tracking Program");
            Console.WriteLine($"Total Score: {_totalScore}");
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;
        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter completion target: ");
                int completionTarget = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, completionTarget, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    static void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            string progress = goal is ChecklistGoal checklistGoal ? $" - {checklistGoal.GetProgress()}" : "";
            
            Console.WriteLine($"{i + 1}. {status} {goal.GetName()} ({goal.GetDescription()}){progress}");
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        if (_goals.Count == 0) return;

        Console.Write("Enter the number of the goal you completed: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[goalIndex];
        
        if (selectedGoal.IsComplete() && selectedGoal.GetType() != typeof(EternalGoal))
        {
            Console.WriteLine("This goal has already been completed.");
            return;
        }

        selectedGoal.RecordEvent();
        _totalScore += selectedGoal.GetPoints();

        Console.WriteLine($"Goal '{selectedGoal.GetName()}' recorded. Points earned: {selectedGoal.GetPoints()}");
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_totalScore);
                foreach (Goal goal in _goals)
                {
                    // You would need to implement a more robust serialization method
                    if (goal is SimpleGoal simpleGoal)
                        writer.WriteLine($"SimpleGoal,{simpleGoal.GetName()},{simpleGoal.GetDescription()},{simpleGoal.GetPoints()}");
                    else if (goal is EternalGoal eternalGoal)
                        writer.WriteLine($"EternalGoal,{eternalGoal.GetName()},{eternalGoal.GetDescription()},{eternalGoal.GetPoints()}");
                    else if (goal is ChecklistGoal checklistGoal)
                        writer.WriteLine($"ChecklistGoal,{checklistGoal.GetName()},{checklistGoal.GetDescription()},{checklistGoal.GetPoints()}");
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        try
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _totalScore = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            // Note: This is a simplified loading. In a real implementation, 
                            // you'd need to load additional ChecklistGoal-specific properties
                            _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), 3, 10));
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}