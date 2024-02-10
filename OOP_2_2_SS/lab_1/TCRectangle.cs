public class TCRectangle
{
    private TPoint2D _topLeft;
    private TPoint2D _bottomRight;

    public TCRectangle()
    {
        _topLeft = new TPoint2D();
        _bottomRight = new TPoint2D();
    }

    public TCRectangle(TPoint2D topLeft, TPoint2D bottomRight)
    {
        _topLeft = topLeft;
        _bottomRight = bottomRight;
    }

    public TPoint2D TopLeft
    {
        get => _topLeft;
        set => _topLeft = value;
    }

    public TPoint2D BottomRight
    {
        get => _bottomRight;
        set => _bottomRight = value;
    }

    public double Area()
    {
        return Math.Abs((_bottomRight.X - _topLeft.X) * (_bottomRight.Y - _topLeft.Y));
    }

    public double Perimeter()
    {
        return 2 * (_bottomRight.X - _topLeft.X + _topLeft.Y - _bottomRight.Y);
    }

    public bool IsInside(TPoint2D point)
    {
        return point.X >= _topLeft.X && point.X <= _bottomRight.X &&
               point.Y <= _topLeft.Y && point.Y >= _bottomRight.Y;
    }
}