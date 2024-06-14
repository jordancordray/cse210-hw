class ReflectionActivity : Activity {

    private List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];


    public ReflectionActivity(string title, string description, int duration): base(title, description, duration){
    }

    public string GetPrompt(){
        Random rand = new();
        int randomIndex = rand.Next(0, _prompts.Count);
        string prompt = _prompts[randomIndex];
        
        return prompt;
    }

    public string GetQuestion(){
        Random rand = new();
        int randomIndex = rand.Next(0, _questions.Count);
        string question = _questions[randomIndex];
        
        return question;
    }

    public void RunReflection(){
        DisplayStart();
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        LoadingAnimation();
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine(GetPrompt());
        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        string enter = Console.ReadLine();
        if (enter == ""){
            Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            CountdownTimer(5);
            Console.Clear();

            int time = 0;
            while (time < _duration){
                Console.WriteLine(GetQuestion());
                LoadingAnimation();
                time += 5;
            }
        }

        DisplayEnd();
    }
}       