namespace AreaCalcLib.Source;

public class Triangle : IFigure
{
    public double A { set; get; }
    public double B { set; get; }
    public double C { set; get; }

    // Half P = (a+b+c)/2
    public double HalfP => (A + B + C) / 2;

    // S = √(p·(p - a)·(p - b)·(p - c))
    public double S => Math.Sqrt(HalfP * (HalfP - A) * (HalfP - B) * (HalfP - C));

    public Triangle() {}

    public Triangle(double a, double b, double c)
    {
        A = a; 
        B = b; 
        C = c;
    }
}