using System;

public class TCRectangle : TPoint2D
{
    public TPoint2D Point1 { get; set; }
    public TPoint2D Point2 { get; set; }
    public TPoint2D Point3 { get; set; }
    public TPoint2D Point4 { get; set; }
    
    public TCRectangle(TPoint2D p1, TPoint2D p2, TPoint2D p3, TPoint2D p4)
    {
        Point1 = p1;
        Point2 = p2;
        Point3 = p3;
        Point4 = p4;
    }

    // Метод для знаходження площі
    public double Area()
    {
        double width = Point1.DistanceTo(Point2);
        double height = Point2.DistanceTo(Point3);
        return width * height;
    }

    // Метод для знаходження периметру
    public double Perimeter()
    {
        double width = Point1.DistanceTo(Point2);
        double height = Point2.DistanceTo(Point3);
        return 2 * (width + height);
    }

    // Метод для визначення того, чи лежить вказана точка всередині прямокутника
    public bool IsPointInside(TPoint2D point)
    {
        double minX = Math.Min(Point1.X, Math.Min(Point2.X, Math.Min(Point3.X, Point4.X)));
        double maxX = Math.Max(Point1.X, Math.Max(Point2.X, Math.Max(Point3.X, Point4.X)));
        double minY = Math.Min(Point1.Y, Math.Min(Point2.Y, Math.Min(Point3.Y, Point4.Y)));
        double maxY = Math.Max(Point1.Y, Math.Max(Point2.Y, Math.Max(Point3.Y, Point4.Y)));

        return (point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY);
    }
}