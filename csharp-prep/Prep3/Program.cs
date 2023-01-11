using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the to the user the magic number.
        // Console.Write("What is the magic number: ");
        // Pass the user magic number to a string variable called userFirstInput.
        // string userFirstInput = Console.ReadLine();
        // Convert the string on int(integer) variable name: userMagicNumber.
        //int userMagicNumber = int.Parse(userFirstInput); 
        ///// the Line10 and line 12 can be convert on one line such on line 21, pass theuser input to a variable and converting the variable on an int.

        int userGuess = -1;

        // to user random on C# first you need to create a radom class and get in on the next integer.
        Random randomVariable = new Random();
        int userMagicNumber = randomVariable.Next(1, 101);

        while (userGuess != userMagicNumber)
        {
            // ask to the user his guess.
            Console.Write("What is your guess? ");
            // Convert the string on int(integer) and pass the user input "console" on the variable to be read.
            userGuess = int.Parse(Console.ReadLine());

            // If the user guess is lower than user magic number, print "Higher" (the magicNumber is higher than the userGuess)
            if (userGuess < userMagicNumber)
            {
                Console.WriteLine("Higher");
            }
            // Else if the user guess is Higher than the user magic number, print "Lower" (The magicNumber is lower than the userGuess)
            else if (userGuess > userMagicNumber)
            {
                Console.WriteLine("Lower");
            }
            // else the user guess is the magicNumber, print ""You guessed it!"
            else
            {
                Console.WriteLine("You guessed it!");
            }
 
        }
    }
}