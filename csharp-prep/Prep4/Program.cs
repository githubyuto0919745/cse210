using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        
    List<int> words = new List <int> ();

    while (true) 
    {
        Console.WriteLine("Please enter number: ");
        string number = Console.ReadLine();
        if (int.TryParse(number, out int numbers))
        {
            if (numbers == 0)
            {
            break; 
            }
            
            else 
            {
            words.Add(number.ToString()); 
            }

        }    
            
        

    } 

        

    int sum = 0;
    foreach (int word in words)
    {
        sum += word;
    }    
       

            
        float average =((float) sum) / words.Count;
        Console.WriteLine($" The sum is: {sum}");
        Console.WriteLine ($" The average is: {average}"); 

    
    int max = numbers[0];

    foreach (int number in nunmbers)
    {
        if(number>max)
        {
            max = number;
        }
    }
    Console.WriteLine($" the max is: {max}");

    }
}