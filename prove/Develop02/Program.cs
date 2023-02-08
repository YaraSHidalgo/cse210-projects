using System;

class Program
{
    static void Main(string[] args)
    {
        // give a welcome message 
        Console.WriteLine("Welcome to the Journal Program! ");
        //space
        Console.WriteLine();

        Entry entry = new Entry();
        entry.DisplayEntry();
    

        //Menu menu = new Menu();
       // menu.MenuDisplay();

       

    }
}