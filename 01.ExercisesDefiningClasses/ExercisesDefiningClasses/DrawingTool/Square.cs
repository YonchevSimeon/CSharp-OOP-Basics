using System;
using System.Collections.Generic;
using System.Text;

public class Square
{
    private int size;

    public int Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public Square(int size)
    {
        this.size = size;
    }

    public void Draw()
    {
        DrawUpperBottomRow();
        DrawMiddleRows();
        DrawUpperBottomRow();
    }

    private void DrawMiddleRows()
    {
        for (int row = 0; row < this.size - 2; row++)
        {
            Console.Write("|");
            Console.Write(new string(' ', this.size));
            Console.WriteLine("|");
        }
    }

    private void DrawUpperBottomRow()
    {
        Console.Write("|");
        Console.Write(new string('-', this.size));
        Console.WriteLine("|");
    }
}
