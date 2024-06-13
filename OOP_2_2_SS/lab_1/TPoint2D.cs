using System;

public class TPoint2D
{
    public double X { get; set; }
    public double Y { get; set; }

    // Конструктор без параметрів
    public TPoint2D()
    {
        X = 0;
        Y = 0;
    }

    // Конструктор з параметрами
    public TPoint2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Конструктор копіювання
    public TPoint2D(TPoint2D point)
    {
        X = point.X;
        Y = point.Y;
    }

    // Введення даних
    public void Input()
    {
        Console.Write("Введіть координату X: ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть координату Y: ");
        Y = Convert.ToDouble(Console.ReadLine());
    }

    // Виведення даних
    public void Output()
    {
        Console.WriteLine($"Точка: ({X}, {Y})");
    }

    // Визначення відстані до іншої точки
    public double DistanceTo(TPoint2D point)
    {
        return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));
    }

    // Визначення квадранту
    public int GetQuadrant()
    {
        if (X > 0 && Y > 0)
            return 1;
        else if (X < 0 && Y > 0)
            return 2;
        else if (X < 0 && Y < 0)
            return 3;
        else if (X > 0 && Y < 0)
            return 4;
        else
            return 0; // Точка на осі
    }

    // Порівняння з іншою точкою
    public bool IsEqual(TPoint2D point)
    {
        return X == point.X && Y == point.Y;
    }

    // Перевантаження оператора +
    public static TPoint2D operator +(TPoint2D p1, TPoint2D p2)
    {
        return new TPoint2D(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Перевантаження оператора -
    public static TPoint2D operator -(TPoint2D p1, TPoint2D p2)
    {
        return new TPoint2D(p1.X - p2.X, p1.Y - p2.Y);
    }
}