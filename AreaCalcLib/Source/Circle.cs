namespace AreaCalcLib.Source;

public class Circle : IFigure
{
    public double Radius { set; get; }

    // S=πR²
    public double S => Math.PI * Radius * Radius;

    public Circle() {}

    public Circle(double r)
    {
        Radius = r;
    }
}