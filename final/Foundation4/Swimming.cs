public class Swimming : Activity
{
    private int _numOfLaps;
    public Swimming(int numOfLaps, string date, int minutes)
      : base(date, minutes)
    {
        _numOfLaps = numOfLaps;
    }

    //behavior
    public override double GetDistance() //(km)
    {
        double distance = _numOfLaps * 50 / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetMinutes()) * 60;
        return speed;
    } 
    public override double GetPace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }

}