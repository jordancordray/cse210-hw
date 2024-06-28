using System.Runtime.CompilerServices;

class ChecklistGoal : Goal {
    private int _required;
    private int _progress;
    private int _bonusPoints;

    public ChecklistGoal(string title, string desc, int points, int required, int bonusPoints) : base (title, desc, points){
        _required = required;
        _progress = 0;
        _bonusPoints = bonusPoints;
        _completed = false;
    }

    public ChecklistGoal(string title, string desc, int points, int progress, int required, int bonusPoints, bool completed) : base (title, desc, points){
        _required = required;
        _progress = progress;
        _bonusPoints = bonusPoints;
        _completed = completed;
    }

    public override void RecordEvent()
    {
        _progress++;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        if (_progress == _required){
            _completed = true;
            _points += _bonusPoints;
            Console.WriteLine($"Congratulations! You earned {_bonusPoints} bonus points.");
        }
    }

    public override void DisplayGoal()
    {
        if (_completed){
            Console.WriteLine($"[X] {_title} ({_desc}) -- Currently completed: {_progress}/{_required}");
        }
        else{
            Console.WriteLine($"[ ] {_title} ({_desc}) -- Currently completed: {_progress}/{_required}");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_title},{_desc},{_points},{_progress},{_required},{_bonusPoints},{_completed}";
    }
}