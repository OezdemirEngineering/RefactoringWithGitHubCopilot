using _02_13_HugeSwitch;

class Program
{
    static void Main(string[] args)
    {
        ShapeAreaCalculator areaCalculator = new ShapeAreaCalculator();
        ShapeLengthCalculator lengthCalculator = new ShapeLengthCalculator();

        Console.WriteLine($"Rectangle Area: {areaCalculator.CalculateArea("Rectangle", 5, 10)}");
        Console.WriteLine($"Rectangle Length: {lengthCalculator.CalculateLength("Rectangle", 5, 10)}");

        Console.WriteLine($"Circle Area: {areaCalculator.CalculateArea("Circle", 5)}");
        Console.WriteLine($"Circle Length: {lengthCalculator.CalculateLength("Circle", 5)}");

        Console.WriteLine($"Square Area: {areaCalculator.CalculateArea("Square", 5)}");
        Console.WriteLine($"Square Length: {lengthCalculator.CalculateLength("Square", 5)}");

        Console.WriteLine($"Triangle Area: {areaCalculator.CalculateArea("Triangle", 5, 10)}");
        Console.WriteLine($"Triangle Length: {lengthCalculator.CalculateLength("Triangle", 5)}");

        Console.WriteLine($"Ellipse Area: {areaCalculator.CalculateArea("Ellipse", 5, 10)}");
        Console.WriteLine($"Ellipse Length: {lengthCalculator.CalculateLength("Ellipse", 5, 10)}");

        Console.WriteLine($"Trapezoid Area: {areaCalculator.CalculateArea("Trapezoid", 5, 10, 15)}");
        Console.WriteLine($"Trapezoid Length: {lengthCalculator.CalculateLength("Trapezoid", 5, 10, 15)}");

        Console.WriteLine($"Parallelogram Area: {areaCalculator.CalculateArea("Parallelogram", 5, 10)}");
        Console.WriteLine($"Parallelogram Length: {lengthCalculator.CalculateLength("Parallelogram", 5, 10)}");

        Console.WriteLine($"Pentagon Area: {areaCalculator.CalculateArea("Pentagon", 5)}");
        Console.WriteLine($"Pentagon Length: {lengthCalculator.CalculateLength("Pentagon", 5)}");

        Console.WriteLine($"Hexagon Area: {areaCalculator.CalculateArea("Hexagon", 5)}");
        Console.WriteLine($"Hexagon Length: {lengthCalculator.CalculateLength("Hexagon", 5)}");

        Console.WriteLine($"Heptagon Area: {areaCalculator.CalculateArea("Heptagon", 5)}");
        Console.WriteLine($"Heptagon Length: {lengthCalculator.CalculateLength("Heptagon", 5)}");

        Console.WriteLine($"Octagon Area: {areaCalculator.CalculateArea("Octagon", 5)}");
        Console.WriteLine($"Octagon Length: {lengthCalculator.CalculateLength("Octagon", 5)}");

        Console.WriteLine($"Nonagon Area: {areaCalculator.CalculateArea("Nonagon", 5)}");
        Console.WriteLine($"Nonagon Length: {lengthCalculator.CalculateLength("Nonagon", 5)}");

        Console.WriteLine($"Decagon Area: {areaCalculator.CalculateArea("Decagon", 5)}");
        Console.WriteLine($"Decagon Length: {lengthCalculator.CalculateLength("Decagon", 5)}");
    }
}
