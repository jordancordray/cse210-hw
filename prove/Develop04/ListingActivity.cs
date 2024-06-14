class ListingActivity : Activity {
    private List<string> _prompts = [
"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

    public string GetPrompt(){
        Random rand = new();
        int randomIndex = rand.Next(0, _prompts.Count);
        string prompt = _prompts[randomIndex];
        
        return prompt;
    }

    public ListingActivity(string title, string description, int duration): base(title, description, duration){
    }
    public void RunListing(){
        DisplayStart();
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready!");
        LoadingAnimation();

        Console.WriteLine("List as many responses as you can for the following prompt: ");
        Console.WriteLine(GetPrompt());
        Console.Write("You may begin in: \n");
        CountdownTimer(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        int responseNum = 0;
        while (currentTime <= endTime){
            Console.Write(">");
            string response = Console.ReadLine();
            if (response != ""){
                responseNum++;
            }
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {responseNum} items");
        DisplayEnd();
    }
}       