public class Listing : Activities
{
  protected List<string>_asking;
  protected List<string>_responses;
  protected List<Entry> entries;

  public Listing(string activities, string description, string ending) 
      :base (activities, description, ending)
  {
      _asking = new List<string>
      {
        "Who are people that you appreciate? ",
        "What are you personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghos this month? ",
        "Who are some of your personal heroes? "
      };
      _responses = new List<string>();
  }

   public void ListingPonder()
  {
    System.Console.WriteLine("You may begin in: ");
    Countdown(3);
  }


  public void GetRandomAsking()
  {
    Random random = new Random();
    int index = random.Next(0,_asking.Count);
    string asking = _asking[index];
    System.Console.WriteLine("\nList as many responses you can to the following prompt: ");
    System.Console.WriteLine($"--- {asking}--- ");
  }

  public void Run()
  {
      string answer;
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_duration);

      while (DateTime.Now < endTime)
      {
        Console.WriteLine("\n>");
        answer = Console.ReadLine();
        _responses.Add(answer);
      }
      System.Console.WriteLine($"you listed {_responses.Count} items!");
  }
 public void ListingComplete()
    {
        System.Console.WriteLine($" \nYou have completed {_duration} seconds of the {_activities} Activity");
    }

  public void SaveJournal(string fileName)
  {
      try
      {
          System.Console.WriteLine("Saving responses to file: "+fileName);
          using (StreamWriter writer = new StreamWriter(fileName))
          {
              foreach ( string response in _responses)
              {
                  writer.WriteLine(response);
              }
          }
          System.Console.WriteLine("Save successful!");
      }
      catch (Exception ex)
      {
          System.Console.WriteLine("Error saving file: " + ex.Message);
      }
  }   

  



}