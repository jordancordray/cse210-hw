using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string FirstNameJC = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string LastNameJC = Console.ReadLine();
        
        Console.WriteLine($"\nYour name is {LastNameJC}, {FirstNameJC} {LastNameJC}.");
    }
}