public class TPoint2D
{
    private double _x;
    private double _y;

    public TPoint2D()
    {
        _x = 0;
        _y = 0;
    }

    public TPoint2D(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public TPoint2D(TPoint2D point)
    {
        _x = point._x;
        _y = point._y;
    }

    public double X
    {
        get => _x;
        set => _x = value;
    }

    public double Y
    {
        get => _y;
        set => _y = value;
    }

    public void Input()
    {
        Console.Write("Введіть координату X: ");
        _x = double.Parse(Console.ReadLine());
        Console.Write("Введіть координату Y: ");
        _y = double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine($"({X}, {Y})");
    }

    public double DistanceTo(TPoint2D point)
    {
        return Math.Sqrt(Math.Pow(point.X - _x, 2) + Math.Pow(point.Y - _y, 2));
    }

    public int Quadrant()
    {
        if (_x > 0 && _y > 0)
            return 1;
        else if (_x < 0 && _y > 0)
            return 2;
        else if (_x < 0 && _y < 0)
            return 3;
        else
            return 4;
    }

    public static bool operator ==(TPoint2D point1, TPoint2D point2)
    {
        return point1.X == point2.X && point1.Y == point2.Y;
    }

    public static bool operator !=(TPoint2D point1, TPoint2D point2)
    {
        return !(point1 == point2);
    }

    public static TPoint2D operator +(TPoint2D point1, TPoint2D point2)
    {
        return new TPoint2D(point1.X + point2.X, point1.Y + point2.Y);
    }

    public static TPoint2D operator -(TPoint2D point1, TPoint2D point2)
    {
        return new TPoint2D(point1.X - point2.X, point1.Y - point2.Y);
    }
}
