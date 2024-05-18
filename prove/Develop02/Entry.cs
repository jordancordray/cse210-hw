class Entry 
{
    public DateTime _entryDate;
    public string _entryText;
    public string _entryPrompt;

    public void DisplayEntry() {
        string dashes = new string('-', 100);
        Console.WriteLine($"{dashes}\nDate: {_entryDate} - Prompt: {_entryPrompt}");
        Console.WriteLine($"{_entryText}\n{dashes}");
    }
}