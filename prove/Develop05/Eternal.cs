using System.ComponentModel;

public class Eternal : Goals
{
    public Eternal() : base()
    {
        
    }
    public Eternal (string name, string description, int points)
        : base(name, description, points)
    
    {
        
    }
    public override string ToLongString()
    {
        return $" [ ] {DisplayList()}";
    }
    
    public override string ToFileString()
    {
        return $"Eternal: {base.DisplayFile()}";
    }
}