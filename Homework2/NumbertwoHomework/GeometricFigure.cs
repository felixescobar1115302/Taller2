using System.Globalization;

namespace NumbertwoHomework;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        string areaFormatted = string.Format(CultureInfo.InvariantCulture, "{0:#,##0.00000}", GetArea());
        string perimeterFormatted = string.Format(CultureInfo.InvariantCulture, "{0:#,##0.00000}", GetPerimeter());

        int totalWidth = 15;

        string areaWithPadding = areaFormatted.PadLeft(totalWidth);
        string perimeterWithPadding = perimeterFormatted.PadLeft(totalWidth);

        return $"{Name.PadRight(15)} => Area.....: {areaWithPadding}   Perimeter: {perimeterWithPadding}";
    }    
}