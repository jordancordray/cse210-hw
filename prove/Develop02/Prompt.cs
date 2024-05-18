class Prompt 
{
    public List<string> _prompts = [
    "Who or what inspired me the most today?",
    "What achievement am I most proud of today?",
    "How did I practice self-care or kindness towards myself today?",
    "What was the most memorable moment of today?",
    "In what ways did I challenge myself today?",
    "What am I grateful for today?",
    "How did I contribute positively to someone else's day today?",
    "What did I learn about myself today?",
    "What obstacle did I overcome today, and how did it make me feel?",
    "How did I make progress towards my goals today?",
    "What new perspective did I gain today?",
    "What was the highlight of my interactions with others today?",
    "How did I cope with stress or adversity today?",
    "What made me smile or laugh today?",
    "What small victories did I celebrate today?",
    "How did I demonstrate resilience today?",
    "What did I do today that aligned with my values or beliefs?",
    "How did I show compassion or empathy towards others today?",
    "What new skill or knowledge did I acquire today?",
    "How did I invest in my personal growth or well-being today?"];
        
    public string GeneratePrompt()
    {
        Random rand = new();
        int randomIndex = rand.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}