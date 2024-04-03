using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
    
      List<Goals> goals = new List<Goals>();  
      bool quit = false;
      int _totalPoints = 0;

      while (!quit)
      {
        System.Console.WriteLine($" You have  {_totalPoints} points.");
        System.Console.WriteLine("Menu Options: ");
        System.Console.WriteLine("1. Create New Goal ");
        System.Console.WriteLine("2. List Goals ");
        System.Console.WriteLine("3. Save Goals ");
        System.Console.WriteLine("4. Load Goals ");
        System.Console.WriteLine("5. Record Event ");
        System.Console.WriteLine("6. Quit");
        
        System.Console.Write("Select a choice from the menu ");
        int choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
                System.Console.WriteLine("The type of Goals are:");
                System.Console.WriteLine(" 1. Simple Goal");
                System.Console.WriteLine(" 2. Eternal Goal ");
                System.Console.WriteLine(" 3. Checklist Goal ");
                System.Console.Write("Which type of goal would you liek to create? ");
                int typeGoals = int.Parse(Console.ReadLine());

        


                switch(typeGoals)
                {
                    case 1:
                        Simple simple = new Simple();
                        goals.Add(simple);
                        break;
                    case 2:
                        Eternal eternal = new Eternal();
                        goals.Add(eternal);
                        break;
                    case 3:
                        Checklist checklist = new Checklist();
                        goals.Add(checklist);
                        break;        
                }
                break;
                    
            case 2:
                int i = 1;
                foreach (Goals item in goals)
                {
                    Console.WriteLine($"{i}.{item.ToLongString()} "); 
                    i++;
                }
                break;



            case 3:
                Files filesave = new Files();
                filesave.SaveFile("Goals.txt", goals,_totalPoints);
                break;
            
            case 4:
                Files fileload = new Files();
                (goals, _totalPoints) = fileload.LoadFile("Goals.txt");
                break;
            
            case 5:
                
                Console.WriteLine("The goals are:");

                int j = 1;
                foreach (Goals item in goals)
                {
                    Console.WriteLine($"{j}. {item.DisplayRecordEvent()}");
                    j++; 
                }

                Console.WriteLine("Which goal did you accomplish?");
                int goalToCheck = int.Parse(Console.ReadLine());

                 _totalPoints += goals[goalToCheck-1].Complete();
             

                break;

            
            case 6:
                quit = true;
                break;

        }




      }

    }
   
}