using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double horizontal;
    private double vertical;

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public Rectangle(string id, double width, double height, double horizontal, double vertical)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.horizontal = horizontal;
        this.vertical = vertical;
    }

    public bool Intersection(Rectangle second)
    {
        return this.ContainsRectangle(second) || second.ContainsRectangle(this);
    }

    private bool ContainsRectangle(Rectangle second)
    {
        return this.ContainsPoint(second.horizontal, second.vertical) ||
               this.ContainsPoint(second.horizontal, second.vertical + height) ||
               this.ContainsPoint(second.horizontal + width, second.vertical) ||
               this.ContainsPoint(second.horizontal + width, second.vertical + height);
    }

    private bool ContainsPoint(double horizontal, double vertical)
    {
        return horizontal >= this.horizontal && horizontal <= this.horizontal + width &&
               vertical >= this.vertical && vertical <= this.vertical + height;
    }
}

