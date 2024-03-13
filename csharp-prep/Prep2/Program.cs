using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write(" What is the percentage of your grade? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string mark = "";

        if (number %10 <3 && number>=60 && number<100)
        {
            mark = "-";
        }
        else if (number %10 >=7 && number >=60 && number<94)
        {
            mark = "+";
        }
        else
        {
            mark = " ";
        }



        
        if (number >= 90)
        {
            Console.WriteLine($"A{mark}");
        }
        else if (number >=80)
        {
            Console.WriteLine($"B{mark}");
        }
        else if (number >=70)
        {
            Console.WriteLine($"C{mark}");
        }
        else if (number >=60)
        {
            Console.WriteLine($"D{mark}");
        }
        else
        {
            Console.WriteLine("F");
        }
    }   
}                                                       