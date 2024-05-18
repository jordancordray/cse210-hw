using System;

class Program
{
    static public Journal workingJournal = new();
    static void Main(string[] args)
    {

        string userOption = "1";
        while (userOption != "0"){
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.Write("What would you like to do? ");

            userOption = Console.ReadLine();

            if (userOption == "1"){
                workingJournal.WriteEntry();
            }

            if (userOption == "2"){
                workingJournal.DisplayAllEntries();
            }

            if (userOption == "3"){
                workingJournal.LoadFromFile();
            }

            if (userOption == "4"){
                workingJournal.SaveToFile();
            }
        }   
    }
}