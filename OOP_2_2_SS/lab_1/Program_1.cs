public class Program_1
{
    public Program_1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть координати лівої верхньої точки прямокутника:");
        TPoint2D topLeft = ReadPoint();
        Console.WriteLine("Введіть координати правої нижньої точки прямокутника:");
        TPoint2D bottomRight = ReadPoint();

        TCRectangle rectangle = new TCRectangle(topLeft, bottomRight);

        Console.WriteLine("Площа прямокутника: " + rectangle.Area());
        Console.WriteLine("Периметр прямокутника: " + rectangle.Perimeter());

        Console.WriteLine("Введiть координати точки для перевiрки:");
        TPoint2D point = ReadPoint();

        if (rectangle.IsInside(point))
        {
            Console.WriteLine("Точка лежить всерединi прямокутника.");
        }
        else
        {
            Console.WriteLine("Точка не лежить всерединi прямокутника.");
        }
    }

    static TPoint2D ReadPoint()
    {
        double x, y;
        Console.Write("X: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Невiрний формат числа. Введiть X: ");
        }
        Console.Write("Y: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Невiрний формат числа. Введiть Y: ");
        }
        return new TPoint2D(x, y);
    }
}