using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.Marshalling;

class UserInterface {
    
    private int _totalPoints;
    private List<Goal> _goals = new();
    private Level _level = new(0);

    public void DisplayGoals() {
        Console.WriteLine("\nThe goals are: ");
        foreach (Goal goal in _goals){
            goal.DisplayGoal();
        }
    }

    public void SetTotalPoints(int points){
        _totalPoints += points;
        _level.SetProgress(points);
    }

    public void CreateGoal(){
        Console.WriteLine("The type of goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which goal would you like to create? ");
        string goalChoice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with it? ");
        string pointsStr = Console.ReadLine();
        int points = int.Parse(pointsStr);

        if (goalChoice == "1"){
            SimpleGoal newGoal = new SimpleGoal(title, desc, points);
            _goals.Add(newGoal);
        }
        else if (goalChoice == "2"){
            EternalGoal newGoal = new EternalGoal(title, desc, points);
            _goals.Add(newGoal);
        }
        else if (goalChoice == "3"){
            Console.WriteLine("How many times does this goal have to be completed for a bonus? ");
            string requiredStr = Console.ReadLine();
            int required = int.Parse(requiredStr);
            Console.WriteLine("What is the bonus accomplishing it that many times? ");
            string bonusStr = Console.ReadLine();
            int bonusPoints = int.Parse(bonusStr);

            ChecklistGoal newGoal = new ChecklistGoal(title, desc, points, required, bonusPoints);
            _goals.Add(newGoal);
        }
    }

    public string Menu(){
        _level.CheckLevelUp();
        Console.WriteLine($"\nYou have {_totalPoints} points.");
        Console.WriteLine(_level.DisplayLevel());
        Console.WriteLine("\nMenu options: ");
        Console.WriteLine(" 0. Quit");
        Console.WriteLine(" 1. Create new goal");
        Console.WriteLine(" 2. List goals");
        Console.WriteLine(" 3. Save goals");
        Console.WriteLine(" 4. Load goals");
        Console.WriteLine(" 5. Record event");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    public void Save(){
        Console.Write("Which file would you like to save to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(fileName, false))
        {
            outputfile.WriteLine($"{_totalPoints}");
            outputfile.WriteLine(_level.GetStringRepresentation());

            foreach (Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void Load(){
        Console.Write("Which file would you like to load from? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _totalPoints = int.Parse(lines[0]);
        lines[0].Remove(0);

        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            if (parts[0] == "SimpleGoal"){
                string[] details = parts[1].Split(",");
                SimpleGoal newGoal = new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3]));
                _goals.Add(newGoal);
            }
            else if (parts[0] == "EternalGoal"){
                string[] details = parts[1].Split(",");
                EternalGoal newGoal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                _goals.Add(newGoal);
            }

            else if (parts[0] == "ChecklistGoal"){
                string[] details = parts[1].Split(",");
                ChecklistGoal newGoal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5]), bool.Parse(details[6]));
                _goals.Add(newGoal);
            }
            else if (parts[0] == "Level"){
                string[] details = parts[1].Split(",");
                Level level = new Level(int.Parse(details[0]), int.Parse(details[1]), int.Parse(details[2]));
                _level = level;
            }
        }
    }

    public void FindEvent(){

        Console.WriteLine("The goals are: ");
        int goalCount = 1;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{goalCount}. {goal.GetTitle()}");
            goalCount++;
        }
        Console.Write("Which goal did you accomplish? ");
        string completedGoalStr = Console.ReadLine();
        int completedGoal = int.Parse(completedGoalStr);

        _goals[completedGoal-1].RecordEvent();
        this.SetTotalPoints(_goals[completedGoal-1].GetPoints());
    }
}