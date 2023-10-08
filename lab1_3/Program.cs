using System.Reflection.Metadata;
using System.Xml.Linq;

public class Point
{
    private int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }

}

public class Figure
{
    public enum FigureType
    {
        Triangle,
        Square,
        Pentagon
    }
    private Point[] points;
    private readonly FigureType _figureType;
    public string Name { get; set; }
    public Figure(FigureType figure)
    {
        _figureType = figure;
        switch (_figureType)
        {
            case FigureType.Triangle:
                points = new Point[3];
                break;
            case FigureType.Square:
                points = new Point[4];
                break;
            case FigureType.Pentagon:
                points = new Point[5];
                break;
            default:
                break;
        }
    }
    public Figure(Point p1, Point p2, Point p3, FigureType figureType):this(figureType)
    {
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, FigureType figureType):this(p1,p2,p3,figureType)
    {
        points[3] = p4;
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, FigureType figureType) : this(p1, p2, p3, p4, figureType)
    {
        points[4] = p5;
    }
    public double LengthSide(Point A, Point B) // Длина стороны многоугольника
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    public double PerimeterCalculator() // Периметр многоугольника
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }
        perimeter += LengthSide(points[points.Length - 1], points[0]); // последняя сторона
        return perimeter;
    }
}

class Program3
{
    static void Main(string[] args)
    {

        Point p1 = new(0, 0);
        Point p2 = new(0, 3);
        Point p3 = new(4, 0);
        Figure fig1 = new(p1, p2, p3, Figure.FigureType.Triangle);     
        Console.WriteLine("Perimeter of {0} is {1}", fig1.Name, fig1.PerimeterCalculator());

        Point p4 = new Point(0, 0);
        Point p5 = new Point(0, 5);
        Point p6 = new Point(5, 5);
        Point p7 = new Point(5, 0);
        Figure fig2 = new Figure(p4, p5, p6, p7, Figure.FigureType.Square);
        Console.WriteLine("Perimeter of {0} is {1}", fig2.Name, fig2.PerimeterCalculator());

        Point p8 = new(0, 0);
        Point p9 = new(3, 0);
        Point p10 = new(7, 3);
        Point p11 = new(3, 6);
        Point p12 = new(0, 2);
        Figure fig3 = new(p8, p9, p10, p11, p12, Figure.FigureType.Pentagon);
        Console.WriteLine("Perimeter of {0} is {1}", fig3.Name, fig3.PerimeterCalculator());
    }
}
