using System;

class Program
{
    static void Main(string[] args)
    {
        // Example prompts
        string[] listingPrompts = 
        {
            "List three things you're grateful for.",
            "List five things you want to accomplish today.",
            "List ten things that make you happy.",
            "List three things you love about yourself.",
            "List five places you want to visit.",
            "List ten things you are good at.",
            "List three people who inspire you.",
            "List five things you want to learn.",
            "List ten things you are thankful for.",
            "List three goals you have for the next year.",
            "List five books you want to read.",
            "List ten things that make you laugh.",
            "List three things you want to improve about yourself.",
            "List five things you love about your life.",
            "List ten things you enjoy doing.",
            "List three things you are proud of.",
            "List five things you want to achieve this month.",
            "List ten things you appreciate about your friends.",
            "List three things you are excited about.",
            "List five things you want to try.",
            "List ten things you love about your family.",
            "List three things you are looking forward to.",
            "List five things you want to do this weekend.",
            "List ten things you are passionate about.",
            "List three things you want to change in your life.",
            "List five things you are grateful for today.",
            "List ten things you love about your job.",
            "List three things you want to accomplish this week.",
            "List five things you enjoy about your hobbies.",
            "List ten things you love about your home.",
            "List three things you want to do this year.",
            "List five things you appreciate about your partner.",
            "List ten things you love about yourself."
        };

        string[] reflectionPrompts =
        {
            "What was the highlight of your day?",
            "What can you do tomorrow to improve?",
            "What are you most proud of?",
            "What did you learn today?",
            "What was the most challenging part of your day?",
            "What are you looking forward to tomorrow?",
            "What did you do today that you're proud of?",
            "What made you smile today?",
            "What is one thing you could have done better today?",
            "What is something new you tried today?",
            "What did you do today to help someone else?",
            "What is one thing you are grateful for today?",
            "What is one thing you want to improve on tomorrow?",
            "What was the best part of your day?",
            "What did you do today that made you feel accomplished?",
            "What is one thing you learned about yourself today?",
            "What is one thing you did today that you would like to do again?",
            "What is one thing you did today that you would like to change?",
            "What is one thing you are looking forward to tomorrow?",
            "What is one thing you did today that made you feel happy?",
            "What is one thing you did today that made you feel proud?",
            "What is one thing you did today that made you feel grateful?",
            "What is one thing you did today that made you feel accomplished?",
            "What is one thing you did today that made you feel loved?",
            "What is one thing you did today that made you feel appreciated?",
            "What is one thing you did today that made you feel inspired?",
            "What is one thing you did today that made you feel motivated?",
            "What is one thing you did today that made you feel confident?",
            "What is one thing you did today that made you feel strong?",
            "What is one thing you did today that made you feel brave?",
            "What is one thing you did today that made you feel creative?",
            "What is one thing you did today that made you feel relaxed?",
            "What is one thing you did today that made you feel peaceful?"
        };

        // Randomly select a prompt
        Random random = new();
        string randomListingPrompt = listingPrompts[random.Next(listingPrompts.Length)];
        string randomReflectionPrompt = reflectionPrompts[random.Next(reflectionPrompts.Length)];

        // Create Listing and Reflection activities with random prompts
        Listing listingActivity = new("Gratitude Listing", "List things you're grateful for.", 5, randomListingPrompt);
        Reflection reflectionActivity = new("Daily Reflection", "Reflect on your day.");
        reflectionActivity.SetPrompt(randomReflectionPrompt);
        Breathing breathingActivity = new("Breathing Exercise", "A simple breathing exercise.");

        bool exit = false;
        
        while (!exit)
        {
            // Display the menu
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Listing Exercise");
            Console.WriteLine("3. Reflection Exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.StartActivity();
                    breathingActivity.FinishActivity();
                    break;
                case "2":
                    listingActivity.StartListing();
                    listingActivity.FinishActivity();
                    break;
                case "3":
                    reflectionActivity.StartReflection();
                    reflectionActivity.FinishActivity();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            if (!exit)
            {
                // Pause before displaying the menu again
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}