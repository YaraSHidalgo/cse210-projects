using System;

public class Menu
{
    public void MenuDisplay()
    {
        while(true)
        {   
            //space
            Console.WriteLine();
            // menu option 1 to 6
            Console.WriteLine("Please choose one of the follow options: ");
            Console.WriteLine("1.Write ");
            Console.WriteLine("2.Display ");
            Console.WriteLine("3.Load ");
            Console.WriteLine("4.Save ");
            Console.WriteLine("5.Display a quote motivation ");
            Console.WriteLine("6.Quit ");

            // Getting the user option and pass on a string called "user choose"
            Console.Write("What option do you desire today? ");
            string userChoose = Console.ReadLine();

            if (userChoose == "6")
            {
                Console.WriteLine("Bye! I hoope to see you again tomorrow.");
                // using break statement to the while stop when the user choose be 6
                break;
            }
            else if (userChoose == "1")
            {
                //
                Console.WriteLine("Write option");
            }
            else if (userChoose == "2")
            {
                //
                Console.WriteLine("Display option");
            }
             else if (userChoose == "3")
            {
                //
                Console.WriteLine("Load option");
            }
             else if (userChoose == "4")
            {
                //
                Console.WriteLine("Save option");
            }
             else if (userChoose == "5")
            {
                //
                Console.WriteLine("Quote option");
            }
            else
            {
                Console.WriteLine("Please, select a valid option");
            }
        }
    }
}