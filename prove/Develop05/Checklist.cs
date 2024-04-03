public class Checklist : Goals
{
    protected int _bonus;
    protected int _goalCount;
    protected int _currentCount; 
    
    public Checklist() : base()
    {
        System.Console.WriteLine("How many time does this goal need to be accomplished for a bonus? ");
        _goalCount = int.Parse(Console.ReadLine());
        System.Console.WriteLine("What is the bonus for acomplish that many times?");
        _bonus = int.Parse(Console.ReadLine());
    }
    
    public Checklist(string name, string description, int points, int bonus, int goalCount)
        : base(name, description, points)
    {
        _bonus = bonus;
        _goalCount = goalCount;
        _currentCount = 0;

    }
   
    public int SetCount()
    {
        return _goalCount;   
    }
    public int SetBonus()
    {
       return _bonus;
    }

    public override string  ToLongString()
    {
        string status = _checked ? "[X]" : "[ ]";
        
        if (_currentCount != _goalCount)
        {
           
            status += $" {DisplayList()} --- Currently completed: {_currentCount}/{_goalCount}";
            return status;
        }
        else
        {
            
            return $" {status} {DisplayList()} --- Completed: {_currentCount}/{_goalCount}";

        }
        
    }
    public override int Complete()
    {
        if (_currentCount < _goalCount)
        {
            _currentCount +=1;
            if (_currentCount == _goalCount)
            {
                _checked = true;
                return _points + _bonus;
            }
            else
            {
                return _points;
            }
        }

        else
        {
        return 0;
        }
    }


    public override string ToFileString()
    {
        return $" Checklist: {DisplayFile()}, {_currentCount}, {_goalCount}, {_bonus} ";
    
    }
    
}