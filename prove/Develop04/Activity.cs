class Activity {
    protected string _title;
    protected string _description;
    protected int _duration;

    public Activity(string title, string description, int duration) {
        _title = title;
        _description = description;
        _duration = duration;
    }

    public void LoadingAnimation(){
        for (int i = 0; i< 2; i++){
            int delay = 250;
            Console.Write(">----\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("->---\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("-->--\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("--->-\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("---->\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("----<\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("---<-\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("--<--\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("-<---\b\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("<----\b\b\b\b\b");
            Thread.Sleep(delay);
        }
    }

    public void CountdownTimer(int time){
        while (time > 0){
            int delay = 1000;
            Console.Write($"{time}\b");
            Thread.Sleep(delay);
            time --;
        }
        Console.Write(" \b");

    
    }
    public int GetDuration(){
        return _duration;
    }

    public void SetDuration() {
        Console.Write("\nHow long (in seconds) would you like the activity to last? "); 
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public void DisplayStart() {
        Console.WriteLine($"Welcome to the {_title}");
        Console.WriteLine($"\n{_description}");
    }

    public void DisplayEnd() {
        Console.WriteLine("Well done!");
        LoadingAnimation();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_title}.");
        LoadingAnimation();
    }
}