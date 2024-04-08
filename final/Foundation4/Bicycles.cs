public class Bicycles : Activity{
    private double _speed;
    private double _minutes;
    public Bicycles (string date, string type, int minutes, double speed)
    : base (date, type, minutes)
    {
        _speed = speed;
        _minutes = minutes;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Distance()
    {
        double _distance = _minutes /60 * _speed;
        return Math.Round(_distance,2);
    }
    public override double Pace()
    {
        double pace = 60 / _speed;
        return  Math.Round(pace,2);   
    }
}