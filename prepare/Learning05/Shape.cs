using System;

public abstract class Shape 
{
    //arrtibutes
    private string _color;

    //getter and setter
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    //constructors
    public Shape(string color)
    {
        _color = color;
    }

    //behavior
    public virtual double GetArea()
    {
        return 0;
    } 
    //public abstract double GetArea();

}