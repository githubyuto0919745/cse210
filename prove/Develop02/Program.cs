using System;
using System.Collections.Generic; // Add this for List<>
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<Entry> entries = journal.entries;

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Chooose an option: (type numbers)");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Entry entry = new Entry();
                    entry.entryquestion();
                    if (entry._upper.ToLower() == "yes")
                    {
                        entry._response = entry._response.ToUpper();
                    }
                    entries.Add(entry);


                    break;

                case 2:
                    journal.DisplayJournal();
                    break;

                case 3: 
                    System.Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournal(loadFileName);
                    break;   
                
                case 4:
                    System.Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournal(saveFileName);
                    break;
                
                case 5:
                    quit = true;
                    break;             
                
                default:
                    Console.WriteLine("Invalid choice. Please try again");
                    break;
            }        
   

            

        }
    }
}

