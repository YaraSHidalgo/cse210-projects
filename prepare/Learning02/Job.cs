// Creating the Job class
using System;
// Create the class (Hint this is the public class Job syntax).
public class Job
{
    //Create member variables in the class for each element that this 
    // class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything. 
    public void DisplayJob ()
    {
        // This method should display the job details on the screen in the correct format.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
    public Job()
    {
    
    }


}