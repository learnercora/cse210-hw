public class ChecklistGoal : Goals
{
  private string _checklistGoal;
  private string _shortDescription;
  private int _point;
  private int _bounsTimes;
  private int _bounsAmount;
  private int _completedTimes;
  private string _status;

  public ChecklistGoal(string checklistGoal, string shortDescription, int point, int bounsTimes, int bounsAmount,int completedTimes,string status, int score): base(score)
  {
      _checklistGoal = checklistGoal;
      _shortDescription = shortDescription;
      _point = point;
      _bounsTimes = bounsTimes;
      _bounsAmount = bounsAmount;
      _completedTimes = completedTimes;
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
    _completedTimes += 1;
    if (_completedTimes == _bounsTimes)
    {
      _status = "[X]";
      base.SetScore(_bounsAmount);
    }
  } 
    
  public override void displayGoalList(int mode)
  {
    if (mode==0)
    {
      Console.WriteLine($"{_status} {_checklistGoal} ({_shortDescription}) --- Currently completed: {_completedTimes.ToString()}/{_bounsTimes.ToString()}");
    }
    else if (mode==1)
    {
      Console.WriteLine(_checklistGoal);
    }
  }
  public override string saveToFile()
  {
      return $"ChecklistGoal: {_checklistGoal}, ShortDescription: {_shortDescription}, Point: {_point}, Status: {_status}, BounsTimes: {_bounsTimes}, BounsAmount: {_bounsAmount}, CompletedTimes: {_completedTimes}";
  }
  public override void loadFromFile()
  {
  } 
}