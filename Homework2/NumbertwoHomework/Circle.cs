
namespace NumbertwoHomework;

public class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get => _r;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Radius R must be greater than 0");
            _r = value;
        }
    }

    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    public override double GetArea() => Math.PI * Math.Pow(R, 2);
    public override double GetPerimeter() => 2 * Math.PI * R;

    public bool ValidateR()
    {
        return R > 0; 
    }    
}