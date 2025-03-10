
using System.Xml.Linq;

namespace NumbertwoHomework;

public class Rhombus : Square
{
    private double _d1, _d2;

    
    public double D1
    {
        get => _d1;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Diagonal D1 must be greater than 0");
            _d1 = value;
        }
    }

    public double D2
    {
        get => _d2;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Diagonal D2 must be greater than 0");
            _d2 = value;
        }
    }

    public Rhombus(string name, double a, double d1, double d2): base(name, a)
    {
        Name = name;
        D1 = d1;
        D2 = d2;
    }

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 4 * A;

    public bool ValidateD1()
    {
        return D1 > 0;
    }
    
    public bool ValidateD2()
    {
        return D2 > 0;
    }    
}