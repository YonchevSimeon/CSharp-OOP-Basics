using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private int width;
    private int height;

    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }
    
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        DrawUpperBottomRow();
        DrawMiddleRows();
        DrawUpperBottomRow();
    }

    private void DrawMiddleRows()
    {
        for (int row = 0; row < this.height - 2; row++)
        {
            Console.Write("|");
            Console.Write(new string(' ', this.width));
            Console.WriteLine("|");
        }
    }

    private void DrawUpperBottomRow()
    {
        Console.Write("|");
        Console.Write(new string('-', this.width));
        Console.WriteLine("|");
    }
}

