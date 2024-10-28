using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_13_HugeSwitch;

public class ShapeAreaCalculator
{
    public double CalculateArea(string shapeType, double length, double width = 0, double height = 0)
    {
        switch (shapeType)
        {
            case "Rectangle":
                return length * width;

            case "Circle":
                return Math.PI * length * length;

            case "Square":
                return length * length;

            case "Triangle":
                return 0.5 * length * height;

            case "Ellipse":
                return Math.PI * (length / 2) * (width / 2);

            case "Trapezoid":
                return 0.5 * (length + width) * height;

            case "Parallelogram":
                return length * height;

            case "Pentagon":
                return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * length * length;

            case "Hexagon":
                return (3 * Math.Sqrt(3) / 2) * length * length;

            case "Heptagon":
                return (7 / 4) * Math.Sqrt(7 / Math.Tan(Math.PI / 7)) * length * length;

            case "Octagon":
                return 2 * (1 + Math.Sqrt(2)) * length * length;

            case "Nonagon":
                return (9 / 4) * Math.Sqrt(9 + 2 * Math.Sqrt(9)) * length * length;

            case "Decagon":
                return 2.5 * length * length * Math.Sqrt(5 + 2 * Math.Sqrt(5));

            default:
                throw new ArgumentException("Unknown shape type");
        }
    }
}

