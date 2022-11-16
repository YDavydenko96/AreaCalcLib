using System;
using AreaCalcLib.Source;

namespace AreaCalcLib_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleS()
        {
            var circe = new Circle(120);
            Assert.AreEqual(circe.S, Math.Pow(circe.Radius, 2) * Math.PI);
        }

        [TestMethod]
        public void TestTriangleHalfP()
        {
            var tri = new Triangle(10, 11, 12);
            Assert.AreEqual(tri.HalfP, (tri.A + tri.B + tri.C) / 2);
        }

        [TestMethod]
        public void TestTriangleS()
        {
            var tri = new Triangle(3, 5, 3);
            Assert.AreEqual(tri.S, Math.Sqrt(tri.HalfP * (tri.HalfP - tri.A) * (tri.HalfP - tri.B) * (tri.HalfP - tri.C)));
        }

        [TestMethod]
        public void TestRectangleS()
        {
            var rect = new Rectangle(50, 75);
            Assert.AreEqual(rect.S, rect.A * rect.B);
        }
    }
}