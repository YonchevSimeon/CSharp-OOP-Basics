﻿using System;

class Program
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Box box = new Box(length, width, height);

        box.PrintSurfaceArea();
        box.PrintLateralSurfaceArea();
        box.PrintVolume();
    }
}
