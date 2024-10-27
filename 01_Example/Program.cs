

using System;

namespace Refactoring_GitHub_Copilot;

class Program
{

    /// <summary>
    /// Calculates the area of a rectangle.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <returns>The area of the rectangle.</returns>
    public double CalculateRectangleArea(double width, double height)
    {
        double area = 0;

        for (int i = 0; i < height; i++)
        {
            area += width;
        }

        return area;
    }
    static void Main(string[] args)
    {

    }
}


