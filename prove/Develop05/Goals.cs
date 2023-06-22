using System;

public abstract class Goals 
{
    //arrtibutes
    private int _score = 0;
    private int _totalScore = 0;

    //getter and setter
    public int GetScore()
    {
        return _score;
    }
    public int GetTotalScore()
    {
        return _totalScore;
    }
    public void SetScore(int score)
    {
        //_score = score;
        _totalScore += score;
    }
    public void SetTotalScore(int totalScore)
    {
        _totalScore = totalScore;
    }
    //constructors
    public Goals(int score)
    {
        _score = score;
    }

    //behavior
    public virtual void createGoal()
    {
    } 

    public virtual void recordEvent()
    {
    } 
    
    public virtual void displayGoalList(int mode)
    {
    } 

    public virtual string saveToFile()
    {
        return "";
    } 

    public virtual void loadFromFile()
    {
    } 

}