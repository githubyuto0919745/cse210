using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;


public class Entry
{
    DateTime date;
    public string _prompt {get; set; }
    public string _response {get; set; }
    public string _date {get; set; }
    public string _upper {get; set; }
    private List<string> prompts;

    public Entry()
    {
        date = DateTime.Now;
        _date = date.ToString("d/M/yyyy");
        prompts = new List<string>
         {
            "What was the best thing that happened to you today?",
            "What is one thing you wish you could have done differently?",
            "Who was your favorite person to talk to?",
            "Did I meet anyone interesting today?",
            "Did I do anything meaningful today?",
            "Did I meet my personal goals today?",
            "What was the coolest thing I saw today?",
            "What was an interesting thought I had today?",
            "What was something I could have done differently?"

        };
        

    }

    public void entryquestion()
    
    {
        List<string> prompts = new List<string>
        {
            "What was the best thing that happened to you today?",
            "What is one thing you wish you could have done differently?",
            "Who was your favorite person to talk to?",
            "Did I meet anyone interesting today?",
            "Did I do anything meaningful today?",
            "Did I meet my personal goals today?",
            "What was the coolest thing I saw today?",
            "What was an interesting thought I had today?",
            "What was something I could have done differently?"

        };
    
    Random random = new Random();
    _prompt = prompts[random.Next(prompts.Count)];

    Console.WriteLine($"Prompts: {_prompt}");
    Console.Write("Enter your response: ");
    _response = Console.ReadLine();
    System.Console.WriteLine("Would you like to capitalized all of your response?");
    //_upper = Console.ReadLine();
    _upper =_response.ToUpper();
    }
    
}   
