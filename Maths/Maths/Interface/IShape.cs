using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.Interface
{
    public interface IShape
    {
        double Area { get; }
        double Perimeter { get; }
        string ShapeName { get; }

        double CalculateArea();
        double CalculatePerimeter();
    }
}
