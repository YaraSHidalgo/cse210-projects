using System;

public class Journal
{
    public List<string> questions = new List<string>()
    {
        "What was the best part of my day?",
        "If I could have done something today, what would it be?",
        "What was the most memorable feeling of my day today?",
        "Which things am I thankful for today?",
        "What is one thing I do not want to forget about this day?",
    };

    

    public void JournalDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();    
        Console.WriteLine($"{dateText}");   
    }
}