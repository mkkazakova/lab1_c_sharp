
public class Rectangle
{
    private double side1;
    private double side2;
    public Rectangle(double A, double B)
    {
        side1 = A;
        side2 = B;
    }
    private double CalculateArea() // Площадь
    {
        return side1 * side2;
    }
    private double CalculatePerimeter() // Периметр
    {
        return 2 * (side1 + side2);
    }
    public double Area
    {
        get { return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину первой стороны прямоугольника:");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину второй стороны прямоугольника:");
        double B = Convert.ToDouble(Console.ReadLine());

        Rectangle rect = new Rectangle(A, B);

        Console.WriteLine("Площадь прямоугольника: " + rect.Area);
        Console.WriteLine("Периметр прямоугольника: " + rect.Perimeter);
    }

}
