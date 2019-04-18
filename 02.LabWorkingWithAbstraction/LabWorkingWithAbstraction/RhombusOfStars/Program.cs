using System;
class Rhombus
{
    static void Main(string[] args)
    {
        int rhombusSize = int.Parse(Console.ReadLine());
        PrintUpper(rhombusSize);
        PrintBottom(rhombusSize);
    }

    private static void PrintBottom(int rhombusSize)
    {
        for (int row = rhombusSize - 1; row >= 1; row--)
        {
            PrintRow(rhombusSize, row);
        }
    }

    private static void PrintUpper(int rhombusSize)
    {
        for (int row = 1; row <= rhombusSize; row++)
        {
            PrintRow(rhombusSize, row);
        }
    }

    private static void PrintRow(int rhombusSize, int row)
    {
        Console.Write(new string(' ', rhombusSize - row));
        for (int star = 1; star < row; star++)
        {
            Console.Write("* ");
        }
        Console.WriteLine("*");
    }
}
