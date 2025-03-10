
namespace NumbertwoHomework;

public class Triangle : Rectangle
{
    private double _c, _h;

    public double C
    {
        get => _c;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side C must be greater than 0");
            _c = value;            
        }
    }

    public double H
    {
        get => _h;
        set
        {
            if(value <= 0)
                throw new ArgumentException("Height must be greater than 0");
            _h = value;
        }
    }

    public Triangle(string name, double a, double b, double c, double h): base(name, a, b)
    {
        Name = name;
        C = c;
        H = h;
    }

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;

    public bool ValidateC()
    {
        return C > 0; 
    }

    public bool ValidateH()
    {
        return H > 0;
    }
}