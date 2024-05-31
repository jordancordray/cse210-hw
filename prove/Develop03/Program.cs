using System;
using System.Xml.Serialization;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Proverbs", "3", "5", "6");
        Scripture scripture = new(reference, "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to Him and He will make your paths straight");
        
        string choice = "a";
        while (choice != "quit"){
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or type 'quit' to finish");
            choice = Console.ReadLine();

            if (choice == ""){
                scripture.HideWords();
                Console.Clear();
                scripture.Display();
                Console.WriteLine();
                Console.WriteLine("Guess the hidden words (from left to right separated by spaces): ");
                string guess = Console.ReadLine();
                bool correct = scripture.CheckGuess(guess);

                if (correct){
                    Console.WriteLine("You guessed correctly!");
                    Console.WriteLine("Press enter to hide words or type 'quit' to finish");
                    choice = Console.ReadLine();                }
                else{
                    Console.WriteLine("One or more guesses was wrong try again.");
                    Console.WriteLine("Press enter to hide words or type 'quit' to finish");
                    choice = Console.ReadLine();
                }
            }
            if (scripture.GetIsCompletelyHidden() == true){
                break;
            }
        }
    }
}