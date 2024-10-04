using System;

class Program
{
    static void Main(string[] args)
    {
                // Create first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "ABC NEWS";
        job1._startYear = 2013;
        job1._endYear = 2020;

        // Create second job instance
        Job job2 = new Job();
        job2._jobTitle = "Junior Executive";
        job2._company = "Fox News";
        job2._startYear = 2020;
        job2._endYear = 2023;
        // Create a resume instance
        Resume myResume = new Resume();
        myResume._name = "Grant Cross";

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();

    }
}