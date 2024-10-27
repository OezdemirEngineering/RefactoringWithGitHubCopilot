
class Program
{

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