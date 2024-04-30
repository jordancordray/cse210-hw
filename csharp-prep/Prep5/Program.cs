using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string nameJC = Console.ReadLine();
        return nameJC;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string inputJC = Console.ReadLine();
        int numberJC = int.Parse(inputJC);
        return numberJC;
    }

    static int SquareNumber(int numberJC)
    {
        int squareJC = numberJC * numberJC;
        return squareJC;
    }

    static void DisplayResult(int squareJC, string nameJC)
    {
        Console.WriteLine($"{nameJC}, the square of your number is {squareJC}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string nameJC = PromptUserName();
        int numberJC = PromptUserNumber();
        int squareJC = SquareNumber(numberJC);
        DisplayResult(squareJC, nameJC);

    }
}