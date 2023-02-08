using System;

class Program
{

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        // give a welcome message 
        Console.WriteLine("Welcome to the Journal Program! ");
        //Console.WriteLine("Please, select one of the following choice: ")
        
        List<string> chooices = new List<string>(){ //Attribute
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit",
        };

        
        // desclaring the user input
        string userInput = "";

        while(userInput != "5"){

           foreach(string choose in chooices)
        {
            Console.WriteLine(choose);
        };
        Console.WriteLine("What option did you like? ");
        userInput = Console.ReadLine();
        //
        if (userInput == "5")
            {
                //space
                Console.WriteLine();

                //Print bye
                Console.WriteLine("Bye! See you tomorrow");
                //break the code if the user answer is 5 = quit.
                break;
            }
        else if (userInput == "1")
        {
            Entry entry = new Entry();
            string question = entry.DisplayQuestions();
            Console.WriteLine($"{question}");
            entry._userAnswer = Console.ReadLine();
            journal._entries.Add(entry);
            // if the user choose is equal to 1, random a question to him and break so the code do not continue
            //DisplayQuestions();
            //break;
        }
        }
       


        //space
        //Console.WriteLine();

        //Entry entry = new Entry();
        //entry.DisplayEntry();
    

        //Menu menu = new Menu();
       // menu.MenuDisplay();

    }
}