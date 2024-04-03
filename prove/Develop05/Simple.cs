public class Simple : Goals
{
    
    
    public Simple() : base()
    {
        
    }
   
    public Simple(string name, string description, int points, bool check)
        : base(name, description, points)
    {
        _checked = check;
    }    
   
    public override string ToLongString()
    {
        string status = _checked ? "[X]" : "[ ]";
        status += DisplayList();
        return status;
    }
    public override string  ToFileString()
    {
        return $"Simple: {DisplayFile()}, {_checked}";
    
    }
}