using System.IO;
using Microsoft.VisualBasic;

class Journal 
{
    public List<Entry> _entries = [];

    public void WriteEntry() 
    {
        Prompt Prompts = new();
        string newPrompt = Prompts.GeneratePrompt();
        Console.WriteLine(newPrompt);

        Entry newEntry = new()
        {
            _entryPrompt = newPrompt,
            _entryDate = DateTime.Now,
            _entryText = Console.ReadLine()
        };

        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries){
            entry.DisplayEntry();
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Which file would you like to load from? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry loadedEntry = new();
            DateTime date = DateTime.Parse(parts[0]);
            loadedEntry._entryDate = date;
            loadedEntry._entryPrompt = parts[1];
            loadedEntry._entryText = parts[2];

            _entries.Add(loadedEntry);
        }
    }


    public void SaveToFile()
    {
        Console.Write("Which file would you like to save to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(fileName, true))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._entryDate},{entry._entryPrompt},{entry._entryText}");
            }
        }
    }

}
