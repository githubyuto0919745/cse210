using System;
using System.Collections;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        while (!quit)
        {
            System.Console.WriteLine("\nMenu Options:");
            System.Console.WriteLine("1. Start breathing activity");
            System.Console.WriteLine("2. Start reflecting activity");
            System.Console.WriteLine("3. Start listing activity");
            System.Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Breathing b = new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "\nWell Done!!");
                    Console.WriteLine(b.DisplayWelcomeMessage());
                    Console.WriteLine(b.Description());
                    b.SetDuration();
                    Console.WriteLine(b.GetReady());
                    b.Animation();
                    b.BreathingExcerise();
                    Console.WriteLine( b.EndingMessage());
                    b.Animation();
                    Console.WriteLine(b.BreathingComplete());
                    b.Animation();

                    
                    break;
                case 2:
                    Reflection r = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "\nWell Done!");
                    Console.WriteLine(r.DisplayWelcomeMessage());
                    Console.WriteLine(r.Description());
                    r.SetDuration();
                    Console.WriteLine(r.GetReady());
                    r.Animation();
                    r.GetRandomPrompts();
                    r.ReflectionPonder();
                    r.GetRandomQuestions();
                    r.Animation();
                    Console.WriteLine( r.EndingMessage());
                    r.Animation();
                    r.ReflectionComplete();
                    r.Animation();

                     break;
                case 3:
                    Listing l = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "\nWell Done!");
                    Console.WriteLine(l.DisplayWelcomeMessage());
                    Console.WriteLine(l.Description());
                    l.SetDuration();
                    Console.WriteLine(l.GetReady());
                    l.Animation();
                    l.ListingPonder();
                    l.GetRandomAsking(); 
                    l.Run();
                    Console.Write("Enter the file name to load: ");
                    string fileName = Console.ReadLine();
                    l.SaveJournal(fileName);
                    Console.WriteLine( l.EndingMessage());
                    l.Animation();
                    l.ListingComplete();
                    l.Animation();


                    break;
                case 4:
                
                    Environment.Exit(0);
                    break;


            }

            

        }
    }
}