using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Make a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),    // 3 miles, 30 minutes
            new Cycling(new DateTime(2022, 11, 4), 30, 15.0),   // 15 mph, 30 minutes
            new Swimming(new DateTime(2022, 11, 5), 30, 20)    // 20 laps, 30 minutes
        };

        // Go through the list and print the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}