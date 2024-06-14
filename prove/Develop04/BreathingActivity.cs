class BreathingActivity : Activity {

    static int _time = 0;
    public BreathingActivity(string title, string description, int duration): base(title, description, duration){
    }

    public void BreatheIn(){
        Console.Write("Breathe in...");
        CountdownTimer(4);
        _time += 4;
    }

    public void BreatheOut(){
        Console.Write("\nBreathe out...");
        CountdownTimer(6);
        _time += 6;
    }

    public void RunBreathing(){
        DisplayStart();
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        LoadingAnimation();

        while (_time < _duration){
    
            BreatheIn();
            BreatheOut();
            Console.WriteLine("\n");
        }

        DisplayEnd();
    }


}      