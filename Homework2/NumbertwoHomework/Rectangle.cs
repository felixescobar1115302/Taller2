
namespace NumbertwoHomework;

public class Rectangle : Square
{
    private double _b;

    public double B
    {
        get => _b;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side B must be greater than 0");
            _b = value;
        }
    }

    public Rectangle(string name, double a, double b): base(name, a)
    {
        Name = name;
        B = b;
    }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);

    public bool ValidateB()
    {
        return B > 0;
    }
}