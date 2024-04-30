using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numJC = 1;

        while (numJC != 0)
        {
            Console.WriteLine("Enter a list of Numbers, type 0 when you are done.");
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            numJC = int.Parse(input);
            numbers.Add(numJC);

            
        }
        int totalJC = 0;
        foreach (int number in numbers)
        {
            totalJC += number;
        }

        double averageJC = (double)totalJC / numbers.Count;

        int largestJC = 0;

        foreach (int number in numbers)
        {
            if (largestJC < number)
            {
                largestJC = number;
            }
        }




        Console.WriteLine($"The sum is: {totalJC}");
        Console.WriteLine($"The average is: {averageJC}");
        Console.WriteLine($"Largest Number is: {largestJC}");
    }
}