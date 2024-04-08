public abstract class Activity
{
    private string _date;
    private string _type;
    private int _minutes;

    public Activity(string date, string type, int minutes)
    {
        _date = date;
        _type = type;
        _minutes = minutes;
    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public void GetSummary()
    {
        System.Console.WriteLine($"{_date} {_type} ({_minutes})- Distance:{Distance()} miles, Speed:{Speed()} mph, Pace: {Pace()} min per mile");
    }
}