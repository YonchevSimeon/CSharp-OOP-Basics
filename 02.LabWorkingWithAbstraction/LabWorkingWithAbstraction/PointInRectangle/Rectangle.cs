public class Rectangle
{
    private Point topLeft;
    private Point bottomRight;

    public Point TopLeft
    {
        get { return this.topLeft; }
        private set { this.topLeft = value; }
    }

    public Point BottomRight
    {
        get { return this.bottomRight; }
        private set { this.bottomRight = value; }
    }

    public Rectangle(Point top, Point bottom)
    {
        this.topLeft = top;
        this.bottomRight = bottom;
    }

    public bool Contains(Point point)
    {
        if(point.CoordinateX >= this.topLeft.CoordinateX &&
           point.CoordinateY >= this.topLeft.CoordinateY &&
           point.CoordinateX <= this.bottomRight.CoordinateX &&
           point.CoordinateY <= this.bottomRight.CoordinateY)
        {
            return true;
        }
        return false;
    }
}
