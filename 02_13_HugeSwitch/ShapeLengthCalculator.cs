public class ShapeLengthCalculator
{
    public double CalculateLength(string shape, params double[] dimensions)
    {
        switch (shape)
        {
            case "Rectangle":
                return 2 * (dimensions[0] + dimensions[1]);
            case "Circle":
                return 2 * Math.PI * dimensions[0];
            case "Square":
                return 4 * dimensions[0];
            case "Triangle":
                // Assuming it's an equilateral triangle
                return 3 * dimensions[0];
            case "Ellipse":
                // Approximation using Ramanujan's formula for the circumference of an ellipse
                double a = dimensions[0];
                double b = dimensions[1];
                return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
            case "Trapezoid":
                // Assuming it's an isosceles trapezoid
                double base1 = dimensions[0];
                double base2 = dimensions[1];
                double height = dimensions[2];
                double leg = Math.Sqrt(Math.Pow((base2 - base1) / 2, 2) + Math.Pow(height, 2));
                return base1 + base2 + 2 * leg;
            case "Parallelogram":
                // Assuming it's a rectangle for simplicity
                return 2 * (dimensions[0] + dimensions[1]);
            case "Pentagon":
                return 5 * dimensions[0];
            case "Hexagon":
                return 6 * dimensions[0];
            case "Heptagon":
                return 7 * dimensions[0];
            case "Octagon":
                return 8 * dimensions[0];
            case "Nonagon":
                return 9 * dimensions[0];
            case "Decagon":
                return 10 * dimensions[0];
            default:
                throw new ArgumentException("Unknown shape");
        }
    }
}
