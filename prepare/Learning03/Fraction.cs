using System.Runtime.CompilerServices;
using System.Xml.Schema;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Set default value  t  1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNNumber) 
    {
        _top = wholeNNumber;
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
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double value = _top / (double)_bottom; // (double) transformma integer on decimal
        return value;
    }
}

