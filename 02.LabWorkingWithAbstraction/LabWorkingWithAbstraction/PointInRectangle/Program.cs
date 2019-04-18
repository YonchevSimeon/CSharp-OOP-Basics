using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] rectanglesArgs = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Rectangle rectangle = GetRectangle(rectanglesArgs); 

        int numberOfPointsToCheck = int.Parse(Console.ReadLine());

        List<Point> pointsToCheck = GetPointsToCheck(numberOfPointsToCheck);

        CheckPoints(pointsToCheck, rectangle);
    }

    private static void CheckPoints(List<Point> pointsToCheck, Rectangle rectangle)
    {
        foreach (Point point in pointsToCheck)
        {
            Console.WriteLine(rectangle.Contains(point));
        }
    }

    private static List<Point> GetPointsToCheck(int numberOfPointsToCheck)
    {
        List<Point> points = new List<Point>();
        for (int curr = 0; curr < numberOfPointsToCheck; curr++)
        {
            int[] currentPointCoordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Point currentPoint = new Point(currentPointCoordinates[0], currentPointCoordinates[1]);
            points.Add(currentPoint);
        }
        return points;
    }

    private static Rectangle GetRectangle(int[] rectanglesArgs)
    {
        Point topRectanglePoint = new Point(rectanglesArgs[0], rectanglesArgs[1]);
        Point bottomRectanglePoint = new Point(rectanglesArgs[2], rectanglesArgs[3]);

        Rectangle rectangle = new Rectangle(topRectanglePoint, bottomRectanglePoint);

        return rectangle;
    }
}

