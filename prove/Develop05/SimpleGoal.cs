class SimpleGoal : Goal{

    public SimpleGoal(string title, string desc, int points) :base (title, desc, points){
    }

    public SimpleGoal(string title, string desc, int points, bool completed) :base (title, desc, points){
        _completed = completed;
    }

    public override void RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
    }

    public override void DisplayGoal()
    {
        if (_completed){
            Console.WriteLine($"[X] {_title} ({_desc})");
        }
        else{
            Console.WriteLine($"[ ] {_title} ({_desc})");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_title},{_desc},{_points},{_completed}";
    }

}   