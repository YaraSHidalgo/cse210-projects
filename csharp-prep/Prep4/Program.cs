using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a new list<int> 
        List<int> numbers = new List<int>();

         // create a int variable to the user input number.
        int userNumber = -1;
        
        // Startup message to the user.
        Console.WriteLine("Welcome!Enter a list of numbers, type 0 when finished.");
        
        //While the user input is not 0 continue to ask the user number.
        while (userNumber != 0)
        {
            // ask the user to input a number and pass to integer variable and read the user input "Console.ReadLine()".
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            if (userNumber != 0 )
            {   
                //append (.Add) the user number's on the list.
                numbers.Add(userNumber);
            }
        }

        //getting the total number in the list, storage then on a variable called "listSize" and print out.
        int listSize = numbers.Count;
        //Console.WriteLine(numbers.Count);
        Console.WriteLine($"The list size is: {listSize}");

        // getting the sum list using foreach to iterate the list
        int sum = 0;
        // for each number (new int variable in numbers list sum all.)
        foreach ( int number in numbers )
        {
            sum += number;
        }
        //Print the sum list
        Console.WriteLine($"The list sum is: {sum}");

        // Getting the avarage value on float (sum)/listSize on the line 32. 
        float average = (float)sum / listSize;
        Console.WriteLine($"The average list is: {average}");
        
        // getting the max(the largest one) value of the list numbers using "Max()"
        int maxValue = numbers.Max();
        Console.WriteLine($"The largest number is: {maxValue}");
    }
}


// ANOTHER WAY TO FIND THE MAX VALUE OF THE LIST
// Part 3: Find the max
        //// There are several ways to do this, such as sorting the list
        
        //int max = numbers[0];

       //foreach (int number in numbers)
        //{
            //if (number > max)
            //{
                //77 if this number is greater than the max, we have found the new max!
                //max = number;
            //}
        //}