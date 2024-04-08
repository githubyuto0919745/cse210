public class Running : Activity
{
    private double _distance;
    private int _minutes;
    public Running (string date, string type, int minutes, int distance)
    : base(date, type, minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }
    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double _speed = _distance / _minutes * 60;
        return Math.Round(_speed,2);
    }

    public override double Pace()
    {
        double pace = _minutes / _distance;
        return  Math.Round(pace,2);
    }
}