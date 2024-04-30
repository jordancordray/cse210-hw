using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGeneratorJC = new Random();
        int numberJC = randomGeneratorJC.Next(1, 100);

        bool notGuessedJC = true;

        int guessesJC = 0;

        while (notGuessedJC)
        {
            Console.Write("Guess the Magic Number: ");
            string guessJC = Console.ReadLine();
            int intguessJC = int.Parse(guessJC);
            guessesJC ++;

            if (intguessJC < numberJC)
            {
                Console.WriteLine("Higher!");
            }

            else if (intguessJC > numberJC)
            {
                Console.WriteLine("Lower!");
            }

            else if (intguessJC == numberJC)
            {
                Console.WriteLine($"You guessed it in {guessesJC} guesses!");
                notGuessedJC = false;
            }
        }



    }
}