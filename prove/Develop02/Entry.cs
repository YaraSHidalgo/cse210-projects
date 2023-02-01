using System;
using System.Collections.Generic;

public class Entry
{
    string _userChoose;
    //Attribute

    string _userAnswer;
    //Attribute
    
    //Attribute
    // create a new string list with the menu chooices to the user and display then on foreach on line 23
    public List<string> chooices = new List<string>(){ //Attribute
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit",
    };

    //Attribute
    //create a new public list to random question's about the user day's
    public List<string> questions = new List<string>{
        "What was the best part of my day?",
        "If I could have done something today, what would it be?",
        "What was the most memorable feeling of my day today?",
        "Which things am I thankful for today?",
        "What is one thing I do not want to forget about this day?",
    };

    public void DisplayEntry()
    {
        //While loop, the code will not stop if the user answer is not equal to 5 = quit
        while (_userChoose != "5")
        {
            Console.WriteLine("Please, select one of the following choice: ");

            // Display the list chooices using a loop for each
            foreach (string choose in chooices)
            {
                Console.WriteLine(choose);
            }
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
                DisplayQuestions();
                break;
            }

        }
    }  

    //method (function) to run a random question about the user Journal daily
    public void DisplayQuestions()
    {
        Random random = new Random();
        int question = random.Next(questions.Count);
        Console.Write(questions[question]);  
        _userAnswer = Console.ReadLine();

        // calling the function to display the menu chooices while the user input is not equal to quit = 5.
        DisplayEntry();
    } 

    
}