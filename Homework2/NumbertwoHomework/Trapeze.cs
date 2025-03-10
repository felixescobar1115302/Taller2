
namespace NumbertwoHomework;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side D must be greater than 0");
            _d = value;
        }
    }

  
    public Trapeze(string name, double a, double b, double c, double d, double h): base(name,a,b,c,h)
    {
        Name = name;
        D = d;
    }

    public override double GetArea() => ((B + D) * H) / 2;
    public override double GetPerimeter() => A + B + C + D;

    public bool ValidateD()
    { 
    return D > 0;
    }
}