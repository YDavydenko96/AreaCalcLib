using AreaCalcLib.Source;

namespace AreaCalcLib.Samples
{
    internal class Example2
    {
        public static void Main()
        {
            IFigure a = new Triangle(24, 34, 18);
            IFigure b = new Rectangle(10, 48);

            if (a is Rectangle)
            {
                Console.WriteLine("Figure a is rectangle!");
            }
        }
    }
}
