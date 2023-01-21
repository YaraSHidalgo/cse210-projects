using System;

class Program
{
    static void Main(string[] args)
    {
        //create a new instance of the Job class.
        Job job1 = new Job();
        job1._jobTitle = " Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear =2022;

        //create a new instance of the Resume class.
        Resume resume = new Resume();
        resume._personName = "Allison Rose";

        resume._jobs.Add(job1);

        // to call a funciont do not need the _ just the .
        resume.DisplayResume();
    }
}

