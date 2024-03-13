using System;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();
      job1._jobTitle = "Software Engineer";
      job1._company = "Microsoft";
      job1._startYear = 2019;
      job1._endYear = 2022;

      Job job2 = new Job();
      job2._jobTitle = "Manager";
      job2._company = "Apple";
      job2._startYear = 2022;
      job2._endYear = 2023;

      Resume myResume = new Resume();
      myResume._name = "Allison Rose";

      

      // myResume myResume = new myResume();

      // Console.Write("Enter your name: ");
      // myResume._name = Console.ReadLine();

      // for(int i; ; i++)
      // {
      //   Job job= new Job();

      //   Console.WriteLine($"\nEnter details for job {i} ( Press enter to skip): ");
      //   Console.Write("Job title: ");
      //   job._jobTitle= Console.ReadLine();
      //   if (string.IsNullOrWhiteSpace(job._jobTitile))
      //   break;

      //   Console.Write("Company: ");
      //   job._company = Console.ReadLine();

      //   Console.Write("Start year: ");
      //   int.TryParse(Console.ReadLine()out job._startYear)
       
      //   Console.Write("End year: ");
      //       int.TryParse(Console.ReadLine(), out job._endYear);

      //       myResume._jobs.Add(job);
      // }

      //   myResume.Display();
    
    }

        
  
}