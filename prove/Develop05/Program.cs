using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        while (true)
        {
            Console.WriteLine("\n--- Goal Tracker ---");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List All Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. View Total Points");
            Console.WriteLine("5. Manage Shop");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    totalPoints += RecordEvent(goals);
                    break;
                case "4":
                    Console.WriteLine($"Total Points: {totalPoints}");
                    break;
                case "5":
                    ManageShop(ref totalPoints);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("\n--- Create a New Goal ---");
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the number of points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter the number of times this goal must be completed: ");
                int completionTarget = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, completionTarget, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid choice. Returning to main menu.");
                return;
        }

        goals.Add(newGoal);
        Console.WriteLine($"Goal '{name}' has been created and added to your list!");
    }

    static void ListGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("\n--- List of Goals ---");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
    }

    static int RecordEvent(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to record events for.");
            return 0;
        }

        Console.WriteLine("\n--- Record Event ---");
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }

        Console.Write("Enter the number of the goal to record an event for: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return 0;
        }

        goals[goalIndex].RecordEvent();
        return goals[goalIndex].GetPoints();
    }

    //shop

    static List<ShopItem> shopItems = new List<ShopItem>();

    static void ManageShop(ref int totalPoints)
    {
        while (true)
        {
            Console.WriteLine("\n--- Shop Menu ---");
            Console.WriteLine("1. View Shop Items");
            Console.WriteLine("2. Add New Shop Item");
            Console.WriteLine("3. Purchase Item");
            Console.WriteLine("4. Return to Main Menu");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewShopItems();
                    break;
                case "2":
                    AddShopItem();
                    break;
                case "3":
                    PurchaseItem(ref totalPoints);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewShopItems()
    {
        if (shopItems.Count == 0)
        {
            Console.WriteLine("No items in the shop yet.");
            return;
        }

        Console.WriteLine("\n--- Shop Items ---");
        for (int i = 0; i < shopItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {shopItems[i].GetDetails()}");
        }
    }

    static void AddShopItem()
    {
        Console.Write("Enter the name of the item: ");
        string name = Console.ReadLine();

        Console.Write("Enter the point cost of the item: ");
        int pointCost;
        while (!int.TryParse(Console.ReadLine(), out pointCost) || pointCost <= 0)
        {
            Console.WriteLine("Please enter a valid positive number of points.");
            Console.Write("Enter the point cost of the item: ");
        }

        ShopItem newItem = new ShopItem(name, pointCost);
        shopItems.Add(newItem);
        Console.WriteLine($"Item '{name}' added to the shop for {pointCost} points!");
    }

    static void PurchaseItem(ref int totalPoints)
    {
        if (shopItems.Count == 0)
        {
            Console.WriteLine("No items available to purchase.");
            return;
        }

        ViewShopItems();
        Console.WriteLine($"Your current points: {totalPoints}");

        Console.Write("Enter the number of the item you want to purchase: ");
        int itemIndex;
        while (!int.TryParse(Console.ReadLine(), out itemIndex) || 
               itemIndex < 1 || itemIndex > shopItems.Count)
        {
            Console.WriteLine("Invalid item selection.");
            Console.Write("Enter the number of the item you want to purchase: ");
        }

        // Adjust index for zero-based list
        itemIndex--;

        ShopItem selectedItem = shopItems[itemIndex];

        if (selectedItem.GetIsPurchased())
        {
            Console.WriteLine("This item has already been purchased.");
            return;
        }

        if (totalPoints >= selectedItem.GetPointCost())
        {
            totalPoints -= selectedItem.GetPointCost();
            selectedItem.Purchase();
            Console.WriteLine($"Congratulations! You've purchased {selectedItem.GetName()}.");
            Console.WriteLine($"Remaining points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Sorry, you don't have enough points to purchase this item.");
        }
    }
}