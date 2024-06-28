class EternalGoal :Goal {
    public EternalGoal(string title, string desc, int points) : base(title, desc, points){
    }

    public override void RecordEvent(){
        Console.WriteLine($"Congratulations! You earned {_points} points.");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_title} ({_desc})");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_title},{_desc},{_points}";
    }
}