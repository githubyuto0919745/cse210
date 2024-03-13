using System;
using System.Formats.Asn1;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number?");
        // string number = Console.ReadLine();
        // int numbers = int.Parse(number);

        Random randomGenerator = new Random();
        int numbers = randomGenerator.Next(1,100);
        int counting = 0;
        

        while (true)
        {
           
           

            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            
            int guessing = int.Parse(guess);
            



            counting++;

            if (guessing> numbers)
            {
                Console.WriteLine("Lower");
            }
            else if (guessing< numbers)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You guess it!");
                Console.WriteLine($"Your guesses is {counting}");
                Console.WriteLine("Would you like to play the game again?");
                string answer= Console.ReadLine().ToLower();
            
                

                if (answer == "no")
                {
                    break; 
                }
               
            }
    }   }
}