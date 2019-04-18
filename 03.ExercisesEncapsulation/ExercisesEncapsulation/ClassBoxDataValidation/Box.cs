using System;
public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return this.length; }
        private set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get { return this.width; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get { return this.height; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public void PrintSurfaceArea()
    {
        double surfaceArea = SurfaceArea(this.length, this.width, this.height);
        Console.WriteLine($"Surface Area - {surfaceArea:f2}");
    }

    private double SurfaceArea(double length, double width, double height)
    {
        return (2 * length * width) + (2 * length * height) + (2 * width * height);
    }

    public void PrintLateralSurfaceArea()
    {
        double lateralSurfaceArea = LateralSurfaceArea(this.length, this.width, this.height);
        Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
    }

    private double LateralSurfaceArea(double length, double width, double height)
    {
        return (2 * length * height) + (2 * width * height);
    }

    public void PrintVolume()
    {
        double volume = Volume(this.length, this.width, this.height);
        Console.WriteLine($"Volume - {volume:f2}");
    }

    private double Volume(double length, double width, double height)
    {
        return length * width * height;
    }
}