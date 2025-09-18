using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2025;

        job2._company = "Google";
        job2._jobTitle = "Computer graphics design";
        job2._startYear = 2015;
        job2._endYear = 2020;

        Resume resume1 = new Resume();
        resume1._name = "Elon Musk";
        resume1._jobs = new List<Job> { job1, job2 };

        resume1.DisplayResume();
    }
}