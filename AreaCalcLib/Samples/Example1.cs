using AreaCalcLib.Source;

namespace AreaCalcLib.Samples
{
    internal class Example1
    {
        public static void Main()
        {
            IFigure a = new Circle(120);
            IFigure b = new Triangle(24, 34, 18);

            Console.WriteLine(a.S);
            Console.WriteLine(b.S);
        }
    }
}
