public class Cycling : Activity
{
  private double _speed;

  public Cycling(double speed, string date, int minutes)
      : base(date, minutes)
  {
      _speed = speed;
  }

  //behavior
  public override double GetDistance()
  {
      double distance = (_speed / 60) * GetMinutes();
      return distance;
  }
  public override double GetSpeed()
  {
      return _speed;
  } 
  public override double GetPace()
  {
      double pace = GetMinutes() / GetDistance();
      return pace;
  }

}