using FiguresLib.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Figures.Tests
{
    [TestFixture]
    class TriangleTest
    {
        public static IEnumerable<Tester> TestCases()
        {
            yield return new Tester(5, 4, 3) { Square = 8, IsRight = true };
            yield return new Tester(12, 8, 5) { Square = 14.524, IsRight = false };
            yield return new Tester(5, 5, 5) { Square = 10.825, IsRight = false };
        }

        public class Tester
        {
            public Triangle Triangle { get; }
            public double Square { get; set; }
            public bool IsRight { get; set; }

            public Tester(int a, int b, int c)
            {
                Triangle = new Triangle(a, b, c);
            }

        }

        [TestCaseSource("TestCases")]
        public void TriangleSquareTest(Tester tester)
        {
            var square = tester.Triangle.Square();
            Assert.AreEqual(Math.Round(square, 3), tester.Square);
        }

        [TestCaseSource("TestCases")]
        public void RightTriangleTest(Tester tester)
        {
            var isRight = tester.Triangle.IsRight();
            Assert.AreEqual(isRight, tester.IsRight);
        }
    }
}
