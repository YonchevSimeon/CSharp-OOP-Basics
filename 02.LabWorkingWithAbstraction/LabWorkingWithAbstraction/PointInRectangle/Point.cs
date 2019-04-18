public class Point
{
    private int coordinateX;
    private int coordinateY;

    public int CoordinateX
    {
        get { return this.coordinateX; }
        private set { this.coordinateX = value; }
    }
    public int CoordinateY
    {
        get { return this.coordinateY; }
        private set { this.coordinateY = value; }
    }

    public Point(int x, int y)
    {
        this.coordinateX = x;
        this.coordinateY = y;
    }
}

