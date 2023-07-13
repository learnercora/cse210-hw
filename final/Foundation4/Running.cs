public class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, int minutes)
      : base(date, minutes)
    {
        _distance = distance;
    }

    //behavior
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed() //(kph)
    {
        double speed = (_distance / GetMinutes()) * 60;
        return speed;
    } 
    public override double GetPace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }

}