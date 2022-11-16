namespace AreaCalcLib.Source;

public class Rectangle : IFigure
{
    public double A { set; get; }
    public double B { set; get; }

    // S=ab
    public double S => A * B;

    public Rectangle() {}

    public Rectangle(double a, double b)
    {
        A = a; 
        B = b;
    }
}