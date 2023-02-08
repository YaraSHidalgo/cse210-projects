using System;
using System.Collections.Generic;

public class Entry
{
    string _userChoose;
    //Attribute

    public string _userAnswer;
 

    //Attribute
    //create a new public list to random question's about the user day's
    public List<string> questions = new List<string>{
        "What was the best part of my day?",
        "If I could have done something today, what would it be?",
        "What was the most memorable feeling of my day today?",
        "Which things am I thankful for today?",
        "What is one thing I do not want to forget about this day?",
    };
    public string DisplayQuestions()
    {
        // create a random variable called random
        Random random = new Random();
        // create an instance to call the random and pass on list(question) and count.
        int question = random.Next(questions.Count);
        //print random question (pass the lsit questions and the question random)
        //////Console.Write(questions[question]);  
        //reading the user answer and store it on variable
        //_userAnswer = Console.ReadLine();

        return questions[question];
    } 

    
        //DateTime theCurrentTime = DateTime.Now;
        //string dateText = theCurrentTime.ToShortDateString();    
        //Console.WriteLine($"{dateText}");   



    public void DisplayEntry()
    {
        //While loop, the code will not stop if the user answer is not equal to 5 = quit
        while (_userChoose != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please, select one of the following choice: ");

            // Display the list chooices using a loop for each
            //foreach (string choose in chooices)
           // {
                //Console.WriteLine(choose);
           // }
            //After to display the list of the chooices, ask to the user what option he choose
            Console.Write("What do you like to do? ");
            // reading the user chooice 
            _userChoose = Console.ReadLine();

            if (_userChoose == "5")
            {
                //space
                Console.WriteLine();

                //Print bye
                Console.WriteLine("Bye! See you tomorrow");
                //break the code if the user answer is 5 = quit.
                break;
            }
            else if (_userChoose == "1")
            {
                // if the user choose is equal to 1, random a question to him and break so the code do not continue
                DisplayQuestions();
                break;
            }
            else if (_userChoose == "2")
            {
                Console.WriteLine($"{questions}{_userAnswer}");
                // print the date and time that is find on the Journal class
                //journal.JournalDateTime();
                // print the random question again to the user until the answer is quit.
                DisplayEntry();
                break;
            }

        }
    }  

    //method (function) to run a random question about the user Journal daily

  

    
}