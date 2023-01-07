using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        // space
        Console.WriteLine();

        // ask the user percentage grade 
        Console.Write("Please, inform your percentage grade: ");
        // Pass the user percentage to a string variable to userInput.
        string userInput = Console.ReadLine();
        // Convert the string on int(integer) variable name: userPercentage
        int userPercentage = int.Parse(userInput);

        //create a string letter
        string letter = "";

        // if statements:
        if (userPercentage >= 90)
        {
            letter = "A";
            // Console.WriteLine("Well done! Your grade is A.");
        }
        else if (userPercentage >= 80)
        {
            letter = "B";
            // Console.WriteLine("Good Job, your grade is B.");
        }
        else if (userPercentage >= 70)
        {
            letter = "C";
            //Console.WriteLine("Your grade is C.");
        }
        else if (userPercentage >= 60)
        {
            letter = "D";
            //Console.WriteLine("Your grade os D.");
        }
        else
        {
            letter = "F";
           // if  (userPercentage < 60) 
           // {
           //    Console.WriteLine("Your grade is F."); 
           // }
        }

        Console.WriteLine($"Your grade is: {letter}.");

        // space
        Console.WriteLine();

        //If statements if the user have pass on the course.
        if (userPercentage <70)
        {
            // If the user grade is less than 70, he did not pass.
            Console.WriteLine("Sorry, you did not pass the course. Try again next semester.");
        }
        // else, if the user grade is equal or greater than 70, the user pass on the course.
        else{
            Console.WriteLine("Congratulations, you passed the course.");
        }
    }
}