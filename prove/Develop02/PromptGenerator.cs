
using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What is something new you learned today?",
        "Who made a positive difference in your day?",
        "What is something you are grateful for?",
        "What was the biggest challenge you faced today?",
        "What is one thing you want to improve tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
