using System;

public class Journal
{


    public void JournalDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();    
        Console.WriteLine($"{dateText}");   
    }

}