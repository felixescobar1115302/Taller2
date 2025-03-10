namespace NumbertwoHomework;

public class Square : GeometricFigure
{
    private double _a;

    public double A
    {
        get => _a;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side A must be greater than 0");
            _a = value;
        }
    }

    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    public override double GetArea() => Math.Pow(A, 2);
    public override double GetPerimeter() => 4 * A;

    public bool ValidateA()
    {
        return A > 0;
    }
}