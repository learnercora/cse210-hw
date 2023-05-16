using System;

public class Fraction 
{
    private int _top;
    private int _bottom;
    
    // public void DisplayEntry()
    // {
    //     Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
    //     Console.WriteLine(_response);
    //     Console.WriteLine();
    // }
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
       _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
       _bottom = bottom;
    }

    public string GetFractionString()
    {
        string outputFraction =$"{_top}/{_bottom}";
        return outputFraction;
    }
    public double GetDecimalValue()
    {
        double outputDecimal = (double)_top / (double)_bottom;
        return outputDecimal;
    }

}