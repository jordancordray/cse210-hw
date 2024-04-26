using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string GradePercentageJC = Console.ReadLine();
        int PercentageJC = int.Parse(GradePercentageJC);
        
        string LetterGradeJC = "";

        if (PercentageJC >= 90)
        {
            LetterGradeJC = "A";
        }
        else if  (PercentageJC >= 80)
        {
            LetterGradeJC = "B";
        }
        else if  (PercentageJC >= 70)
        {
            LetterGradeJC = "C";
        }
        else if  (PercentageJC >= 60)
        {
            LetterGradeJC = "D";
        }
        else if (PercentageJC < 60)
        {
            LetterGradeJC = "F";
        }

        Console.WriteLine($"Your letter grade is {LetterGradeJC}");

        if (PercentageJC > 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    } 
}