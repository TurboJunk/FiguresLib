using FiguresLib;
using FiguresLib.Figures;
using NUnit.Framework;

namespace Figures.Tests
{
    [TestFixture]
    public class FigureTest
    {
        private Circle _circle;
        private Triangle _triangle;

        [SetUp]
        public void SetUp()
        {
            _circle = Figure.Circle(5);
            _triangle = Figure.Triangle(3, 5, 4);
        }

        [Test]
        public void CircleTypeTest()
        {
            Assert.That(_circle, Is.TypeOf<Circle>());
        }

        [Test]
        public void TriangleTypeTest()
        {
            Assert.That(_triangle, Is.TypeOf<Triangle>());
        }

        [Test]
        public void FigureSquareTest()
        {
            Assert.AreEqual(Figure.Square(_triangle), 8);
        }
    }
}