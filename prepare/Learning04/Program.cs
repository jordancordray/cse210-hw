using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment sampleAssignment = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(sampleAssignment.GetSummary());
    
        MathAssignment math = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}