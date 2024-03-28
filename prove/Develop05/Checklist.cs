public class Checklist : Goals
{
    protected string _bonus;
    protected int _goalCount;
    protected int currentCount; 
    public Checklist(string name, string description, int points, string status)
        : base(name, description, points, status)
    {

    }
}