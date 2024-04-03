using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public abstract class Goals
{
    protected bool _checked = false;

    protected string _name;
    protected string _description;
    protected int _points;
    
    

    public Goals()
    {
        System.Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        _description= Console.ReadLine();
        System.Console.WriteLine("What is the amount of points associated with this goal?");
        _points = int.Parse(Console.ReadLine());
    }
    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // public virtual string SetName()
    // {
        
    //     return _name;
    // }
    // public virtual string SetDescription()
    // {
       
    //     return _description;    
    // }
    public virtual int SetPoints()
    {    


        return _points;
    }
                    
    
   
    public virtual int Complete()
    {
        if(!_checked)
        {
            _checked = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public string DisplayList()
    //ToLongString
    {
        return $" {_name} ({_description})";
    }

    public abstract string ToLongString();
    
    public virtual string DisplayRecordEvent()
    //ToShortString
    {
        return $" {_name}";
    }

    public virtual string DisplayFile()
    //ToFileString
    {
        return $"{_name}, {_description},{_points}";
    }
    public abstract string ToFileString();
    
    
}