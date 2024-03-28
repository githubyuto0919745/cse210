using System.Runtime.CompilerServices;

public class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _status;

    public Goals(string name, string description, int points, string status)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status; 

    }

    public void getname()
    {

    }
    public void getdesc()
    {

    }
    public void getpoints()
    {

    }

    public abstract void DisplayFile()
    //ToFileString
    {

    }
    public void DisplayList() 
    //ToLongString
    {

    }
    public void DisplayRecordEvent()
    //ToShortString
    {
        return System.Console.WriteLine($"");
    }
}