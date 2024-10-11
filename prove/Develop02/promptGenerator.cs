// Prompts: 	1.	What was the highlight of your day, and why did it stand out to you?
	// 2.	Did you face any challenges or obstacles today? How did you handle them?
	// 3.	What is something new you learned or discovered today, either about yourself or the world?
	// 4.	What moment made you feel grateful or happy today?
	// 5.	How did you make progress toward your goals or personal growth today?
	// 6.	Was there anything you wish you had done differently? Why?
	// 7.	Who did you interact with today, and how did those interactions affect your mood or perspective?



// Plan
// Define a PromptGenerator class.
// Add a private field to store a list of journal entry prompts.
// Initialize the list with 7 prompts.
// Add a method to return a random prompt from the list.


using System;
using System.Collections.Generic;

namespace JournalProject
{
	class PromptGenerator
		{
		private List<string> prompts;
		public PromptGenerator()
		{
			prompts = new List<string>
			{
			"What was the highlight of your day, and why did it stand out to you?",
			"Did you face any challenges or obstacles today? How did you handle them?",
			"What is something new you learned or discovered today, either about yourself or the world?",
			"What moment made you feel grateful or happy today?",
			"How did you make progress toward your goals or personal growth today?",
			"Was there anything you wish you had done differently? Why?",
			"Who did you interact with today, and how did those interactions affect your mood or perspective?"
			};
		}

		public string GetRandomPrompt()
		{
			Random random = new Random();
			int index = random.Next(prompts.Count);
			return prompts[index];
		}
	}
}