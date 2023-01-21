using System;

// Resume class
public class Resume 
{
    // Create the member variable for the person's name.
    public string _personName;

    // Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job> , and it is probably easiest to initialize
    // this to a new list right when you declare it..)
    public List<Job> _jobs = new List<Job>();
    
    public void DisplayResume()
    {
        // In the method body, you should display the person's name and then iterate through 
        //each Job instance in the list of jobs and display them.
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: {_jobs}");

        // display each job of the class Joob an a loop
        foreach (Job job in _jobs)
    {
        job.DisplayJob();
    }

    }

}