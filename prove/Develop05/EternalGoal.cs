public class EternalGoal : Goals
{
  private string _eternalGoal;
  private string _shortDescription;
  private int _point;
  private string _status;

  public EternalGoal(string eternalGoal, string shortDescription, int point , string status, int score): base(score)
  {
      _eternalGoal = eternalGoal;
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
    _status = "[ ]";
  } 
    
  public override void displayGoalList(int mode)
  {
    if (mode==0)
    {
      Console.WriteLine($"{_status} {_eternalGoal} ({_shortDescription})");
    }
    else if (mode==1)
    {
      Console.WriteLine(_eternalGoal);
    }
  }
  public override string saveToFile()
  {
      return $"EternalGoal: {_eternalGoal}, ShortDescription: {_shortDescription}, Point: {_point}, Status: {_status}";
  } 
  public override void loadFromFile()
  {
  } 
}