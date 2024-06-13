class Program_1
{
    public Program_1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть координати для точки p1:");
        Console.Write("X: ");
        double p1X = ReadDouble();
        Console.Write("Y: ");
        double p1Y = ReadDouble();
        TPoint2D p1 = new TPoint2D(p1X, p1Y);

        Console.WriteLine("\nВведіть координати для точки p2:");
        Console.Write("X: ");
        double p2X = ReadDouble();
        Console.Write("Y: ");
        double p2Y = ReadDouble();
        TPoint2D p2 = new TPoint2D(p2X, p2Y);

        p1.Output();
        p2.Output();
        Console.WriteLine("Відстань: " + p1.DistanceTo(p2));
        Console.WriteLine("Квадрант p1: " + p1.GetQuadrant());
        Console.WriteLine("Квадрант p2: " + p2.GetQuadrant());

        Console.WriteLine("Додавання точок:");
        TPoint2D p3 = p1 + p2;
        p3.Output();


        Console.WriteLine("\nВведіть координати для точок прямокутника:");
        Console.WriteLine("Введіть координати для точки r1:");
        Console.Write("X: ");
        double r1X = ReadDouble();
        Console.Write("Y: ");
        double r1Y = ReadDouble();
        TPoint2D r1 = new TPoint2D(r1X, r1Y);

        Console.WriteLine("Введіть координати для точки r2:");
        Console.Write("X: ");
        double r2X = ReadDouble();
        Console.Write("Y: ");
        double r2Y = ReadDouble();
        TPoint2D r2 = new TPoint2D(r2X, r2Y);

        Console.WriteLine("Введіть координати для точки r3:");
        Console.Write("X: ");
        double r3X = ReadDouble();
        Console.Write("Y: ");
        double r3Y = ReadDouble();
        TPoint2D r3 = new TPoint2D(r3X, r3Y);

        Console.WriteLine("Введіть координати для точки r4:");
        Console.Write("X: ");
        double r4X = ReadDouble();
        Console.Write("Y: ");
        double r4Y = ReadDouble();
        TPoint2D r4 = new TPoint2D(r4X, r4Y);

        TCRectangle rect = new TCRectangle(r1, r2, r3, r4);

        Console.WriteLine("\nПлоща: " + rect.Area());
        Console.WriteLine("Периметр: " + rect.Perimeter());

        Console.WriteLine("\nВведіть координати для тестової точки:");
        Console.Write("X: ");
        double testPointX = ReadDouble();
        Console.Write("Y: ");
        double testPointY = ReadDouble();
        TPoint2D testPoint = new TPoint2D(testPointX, testPointY);

        Console.WriteLine("Точка всередині: " + rect.IsPointInside(testPoint));
    }
    static double ReadDouble()
    {
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Невiрний формат числа. Введiть Double: ");
        }
        return x;
    }
}
