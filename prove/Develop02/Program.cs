using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program! ");
        Console.WriteLine();
        
        Menu menu = new Menu();
        menu.MenuDisplay();

        Journal journal = new Journal();
        journal.JournalDateTime();

    }
}