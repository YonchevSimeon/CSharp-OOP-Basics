using System;
public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
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