using System;

public class Journal
{

public List<Entry> _entries = new List<Entry>();
    public void JournalDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();    
        Console.WriteLine($"{dateText}");   
    }

}