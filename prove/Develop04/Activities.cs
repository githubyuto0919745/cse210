using System;
using System.Reflection;
using System.Xml;

public class Activities
{
    protected int _duration;
    protected string _activities;
    protected string _description;
    protected string _ending;

    List<string> animation = new List<string>();

    public Activities(string activities, string description, string ending)
    {
        _activities = activities;
        _description = description;
        _ending = ending;
       
        animation.Add("+");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");

    }
    public string DisplayWelcomeMessage()
    {
        return $"Welcome to the {_activities} Activity"; 
    }
    
    public string EndingMessage()
    {
        return _ending;
    }
    
    public string Description()
    {
        return _description;
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would like for your session? " );
        _duration = int.Parse(Console.ReadLine() ?? "0");
    }

    public string GetReady()
    {
        return "Get ready...";
    }
    
    public void Animation()
    {
        // string[] animation = {"+","|","/","-","\\","|","/","-","\\","|"};
        foreach (string anime in animation)
        {
            
            Console.Write(anime);
            Thread.Sleep(250);
            Console.Write("\b \b");
            
        }

    }
    public void Countdown(int? specificDuration = null)
    {
        Random random = new Random();
        int countdownDuration = specificDuration ?? random.Next(3,6);


        for (int i = countdownDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
    }
}  