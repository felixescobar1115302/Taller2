
namespace NumbertwoHomework;

public class Parallelogram : Rectangle
{
    private double _h;

    public double H
    {
        get => _h;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height H must be greater than 0");
            _h = value;
        }
    }

    public Parallelogram(string name, double a, double b, double h): base(name, a, b)
    {
        Name = name;
        H = h;
    }

    public override double GetArea() => B * H;
    public override double GetPerimeter() => 2 * (A + B);

    public bool ValidateH()
    {
        return H > 0;
    }
}