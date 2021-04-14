using FiguresLib.Figures;
using System;

namespace FiguresLib
{
    public static class Figure
    {
        public static Circle Circle(double radius) => new Circle(radius);

        public static Triangle Triangle(double a, double b, double c)
        {
            var sides = new double[] { a, b, c };
            Array.Sort(sides);
            return new Triangle(sides[2], sides[1], sides[0]);
        }

        public static double Square(IFigure figure) => figure.Square();

        public static double Square(double r)
        {
            var circle = Circle(r);
            return Square(circle);
        }

        public static double Square(double a, double b, double c)
        {
            var triangle = Triangle(a, b, c);
            return Square(triangle);
        }

        public static bool IsRigthTriangle(double a, double b, double c)
        {
            var triangle = Triangle(a, b, c);
            return triangle.IsRight();
        }
    }
}
