using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
    
        // ask the user first name and store on the string name.
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        // ask the user last name and store on the string lastName.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print all the data name and lastName string.
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");

    }
}