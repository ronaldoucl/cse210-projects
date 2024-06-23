using System;

public class PromptGenerator {
    private static readonly List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me feel grateful today?",
        "What was the biggest challenge I faced today?"
    };

    public string getRandomPrompt() {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
}