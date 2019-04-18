using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Rectangle> rectangles = new List<Rectangle>();
        int[] inputParams = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        for (int curr = 0; curr < inputParams[0]; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string id = inputTokens[0];
            double width = double.Parse(inputTokens[1]);
            double height = double.Parse(inputTokens[2]);
            double horizontal = double.Parse(inputTokens[3]);
            double vertical = double.Parse(inputTokens[4]);
            rectangles.Add(new Rectangle(id, width, height, horizontal, vertical));
        }

        for (int curr = 0; curr < inputParams[1]; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Rectangle first = rectangles.Find(r => r.Id == inputTokens[0]);
            Rectangle second = rectangles.Find(r => r.Id == inputTokens[1]);
            Console.WriteLine(first.Intersection(second).ToString().ToLower());
        }
    }
}
