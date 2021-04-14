using FiguresLib.Figures;
using NUnit.Framework;
using System;

namespace Figures.Tests
{

    [TestFixture]
    class CircleTest
    {

        [TestCase(2, 12.566)]
        [TestCase(5, 78.54)]
        [TestCase(9, 254.469)]
        public void CircleSquareTest(double r, double result)
        {
            var circle = new Circle(r);
            Assert.AreEqual(Math.Round(circle.Square(), 3), result);
        }
    }
}
