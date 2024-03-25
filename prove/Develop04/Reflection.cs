using System.Security.Cryptography;

public class Reflection : Activities
{
    protected List<string>_prompts;
    protected List<string>_questions;

    public Reflection(string activities, string description, string ending) 
        :base (activities, description, ending)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."


        };

        _questions = new List<string>
        {
           "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before?",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn about yoruself through this experience? ",
            "What did you learn about yoruself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
    } 

    public void GetRandomPrompts()
    {
        string prompt;
        Random random = new Random();
        int index1 = random.Next(0,_prompts.Count);
        prompt = _prompts[index1];
        System.Console.WriteLine(" Consider the following prompt: ");
        System.Console.WriteLine($"---  {prompt} ---");
        System.Console.WriteLine(" When you have something in mind, press enter to continue. ");
        System.Console.ReadLine();
    }

    public void GetRandomQuestions()
    {
        Random random = new Random();
        DateTime startTIime = DateTime.Now;
        DateTime endTime = startTIime.AddSeconds(_duration);
       List<int> usedIndexes = new List<int>();

    while (DateTime.Now < endTime)
    {
        int index;
        do
        {
            index = random.Next(0, _questions.Count);
        } while (usedIndexes.Contains(index));

        usedIndexes.Add(index); 

        string question = _questions[index];
        Console.WriteLine($" > {question}");
        Console.WriteLine("Press Enter for another question...");
        Console.ReadLine();

        if (usedIndexes.Count == _questions.Count)
            usedIndexes.Clear();
    }
    }

    public void ReflectionPonder()
    {
        System.Console.WriteLine("now ponder on each of the following questrions as they related to this experience. ");
        System.Console.WriteLine("You may begin in: ");
        Countdown(3);
    }

    public void ReflectionComplete()
    {
        System.Console.WriteLine($" You have completed {_duration} seconds of the {_activities} Activity");
    }
}
