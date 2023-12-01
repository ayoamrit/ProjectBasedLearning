using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths.Interface;

namespace Maths.Shapes
{
    public class Square : IShape
    {
        private double squareSide { get; set; }
        public double Area { get { return CalculateArea(); } }
        public double Perimeter { get { return CalculatePerimeter(); } }
        public string ShapeName { get { return "Square"; } }

        public Square(double squareSide)
        {
            this.squareSide = squareSide;
        }

        public double CalculateArea()
        {
            //Area of a square is squareSide * squareSide
            double area = (double)squareSide * squareSide;

            return Math.Round(area, 2);
        }

        public double CalculatePerimeter()
        {
            //perimeter of a square is 4 * side of the square
            double perimeter = (double)4 * squareSide;
            return Math.Round(perimeter, 2);
        }

    }
}
