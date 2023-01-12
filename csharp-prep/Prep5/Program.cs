using System;

class Program
{
    static void Main(string[] args)
    {
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        Console.WriteLine("Welcome to the Program!");

        // PromptUserName - Asks for and returns the user's name (as a string)
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

       //  Create a new variable squareResult to pass the function SquareResult on this int variable with the parameter 
       //userNumber, so it can be called this variable on the calling function DisplayResult on line 28.
        int squareResult = SquareResult(userNumber);

        //   Calling the Display result function. It's not posible to put the function SquareResult on the paramenter
        // of the DisplayResult function, so on line 18, was create a new variable squareResult to pass the function
        // SquareResult on this int variable with the parameter userNumber.
        DisplayResult(userName,squareResult);
 
        // FUNCTION - SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareResult (int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }

        // FUNCTION - DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string userName, int square)
        {
           Console.WriteLine($"{userName}, the square of your number is: {square}"); 
        }

    }
}

//////////////// teacher example:
 //DisplayWelcomeMessage();

        //string userName = PromptUserName();
        //int userNumber = PromptUserNumber();

        //int squaredNumber = SquareNumber(userNumber);

        //DisplayResult(userName, squaredNumber);
    //}

    //static void DisplayWelcomeMessage()
    //{
        //Console.WriteLine("Welcome to the program!");
    //}

    //static string PromptUserName()
    //{
        //Console.Write("Please enter your name: ");
        //string name = Console.ReadLine();

        //return name;
    //}

    //static int PromptUserNumber()
    //{
        //Console.Write("Please enter your favorite number: ");
        //int number = int.Parse(Console.ReadLine());

        //return number;
    //}

    //static int SquareNumber(int number)
    //{
        //int square = number * number;
        //return square;
    //}

    //static void DisplayResult(string name, int square)
    //{
        //Console.WriteLine($"{name}, the square of your number is {square}");
    //}
//}