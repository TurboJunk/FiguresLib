using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib.Figures
{
    public class Triangle : IFigure
    {
        public double Hypotenuse { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Triangle(double hypotenuse, double side1, double side2)
        {
            this.Hypotenuse = hypotenuse;
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Square()
        {
            if (this.IsRight())
            {
                return Side1 * Side1 / 2;
            }
            else
            {
                var p = (Hypotenuse + Side1 + Side2) / 2;
                return Math.Sqrt(p * (p - Hypotenuse) * (p - Side1) * (p - Side2));
            }
        }

        public bool IsRight()
        {
            return Math.Pow(Hypotenuse, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2);
        }
    }
}
