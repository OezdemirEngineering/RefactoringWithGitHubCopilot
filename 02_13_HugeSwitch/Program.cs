

//simple main program to test the HugeSwitch class
using System;

namespace _02_13_HugeSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();
            Console.WriteLine($"Rectangle: {calculator.CalculateArea("Rectangle", 5, 10)}");
            Console.WriteLine($"Circle: {calculator.CalculateArea("Circle", 5)}");
            Console.WriteLine($"Square: {calculator.CalculateArea("Square", 5)}");
            Console.WriteLine($"Triangle: {calculator.CalculateArea("Triangle", 5, 10)}");
            Console.WriteLine($"Ellipse: {calculator.CalculateArea("Ellipse", 5, 10)}");
            Console.WriteLine($"Trapezoid: {calculator.CalculateArea("Trapezoid", 5, 10, 15)}");
            Console.WriteLine($"Parallelogram: {calculator.CalculateArea("Parallelogram", 5, 10)}");
            Console.WriteLine($"Pentagon: {calculator.CalculateArea("Pentagon", 5)}");
            Console.WriteLine($"Hexagon: {calculator.CalculateArea("Hexagon", 5)}");
            Console.WriteLine($"Heptagon: {calculator.CalculateArea("Heptagon", 5)}");
            Console.WriteLine($"Octagon: {calculator.CalculateArea("Octagon", 5)}");
            Console.WriteLine($"Nonagon: {calculator.CalculateArea("Nonagon", 5)}");
            Console.WriteLine($"Decagon: {calculator.CalculateArea("Decagon", 5)}");
        }
    }
}