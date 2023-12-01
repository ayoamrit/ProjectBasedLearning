using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths.Interface;

namespace Maths.Shapes
{
    public class Circle : IShape
    {

        public double radius { get; set; }
        public double Area { get { return CalculateArea(); } }
        public double Perimeter { get { return CalculatePerimeter(); } }
        public string ShapeName { get { return "Circle"; } }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            //Area of a circle is πr2
            //π = 3.14

            double area = (double)3.14 * (radius * radius);

            //Rounding the value to 2 digits
            return Math.Round(area, 2);
        }

        public double CalculatePerimeter()
        {
            //Perimeter of a circle is 2πr

            double perimeter = (double)2 * 3.14 * radius;
            return Math.Round(perimeter, 2);
        }
    }
}
