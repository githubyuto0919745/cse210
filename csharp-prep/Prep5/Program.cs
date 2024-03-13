using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName=   PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string names = Console.ReadLine();
        return names;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?");
        int number = int.Parse(Console.ReadLine()) ;
        return number ;
    }

    static int SquareNumber(int number)
    {
        int square =  number*number;
        return square;

    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name},{square}"); 

    }

    }
}