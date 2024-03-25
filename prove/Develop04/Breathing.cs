public class Breathing : Activities
{
    public Breathing(string activities, string description, string ending) 
        :base (activities, description, ending)
    {
        
    } 

    public void BreathingExcerise()
    {   DateTime startTIime = DateTime.Now;
        DateTime endTime = startTIime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write ("\nbreath in...");
            Countdown();
            Console.Write("\nbreath Out...");
            Countdown();    
        }    
        
    }


    public string BreathingComplete()
    {
        return $"\nYou have completed another {_duration} seconds of the Breathing Activity";
    }
}