public class SimpleGoal : Goals
{
  private string _simpleGoal;
  private string _shortDescription;
  private int _point;
  private string _status;

  public SimpleGoal(string simpleGoal, string shortDescription, int point , string status, int score): base(score)
  {
      _simpleGoal = simpleGoal;
      _shortDescription = shortDescription;
      _point = point;
      _status = status;
  }
  public void SetStatus(string status)
  {
      _status = status;
  }

  public override void createGoal()
  {
  } 

  public override void recordEvent()
  {
    _status = "[X]";
  }

  public override void displayGoalList(int mode)
  {
    if (mode==0)
    {
      Console.WriteLine($"{_status} {_simpleGoal} ({_shortDescription})");
    }
    else if (mode==1)
    {
      Console.WriteLine(_simpleGoal);
    }
  }

  public override string saveToFile()
  {
      return $"SimpleGoal: {_simpleGoal}, ShortDescription: {_shortDescription}, Point: {_point}, Status: {_status}";
  }
  public override void loadFromFile()
  {
  } 
}