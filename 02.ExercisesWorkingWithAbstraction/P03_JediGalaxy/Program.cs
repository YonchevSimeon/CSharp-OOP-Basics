using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimestions = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int rows = dimestions[0];
        int cols = dimestions[1];

        int[,] matrix = GetFilledMatrix(rows, cols);


        long sum = 0;
        string command;
        while ((command = Console.ReadLine()) != "Let the Force be with you")
        {
            int[] ivoCoordinates = command
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int ivoRow = ivoCoordinates[0];
            int ivoCol = ivoCoordinates[1];

            int[] evilPowerCoordinates = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int evilPowerRow = evilPowerCoordinates[0]; 
            int evilPowerCol = evilPowerCoordinates[1];

            DoEvilPath(evilPowerRow, evilPowerCol, matrix);
            sum += DoIvoMath(ivoRow, ivoCol, matrix);
        }
        Console.WriteLine(sum);
    }

    private static int DoIvoMath(int ivoRow, int ivoCol, int[,] matrix)
    {
        int sum = 0;
        while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
        {
            if (ivoRow >= 0 && ivoRow < matrix.GetLength(0) && ivoCol >= 0 && ivoCol < matrix.GetLength(1))
            {
                sum += matrix[ivoRow, ivoCol];
            }

            ivoRow--;
            ivoCol++;
        }
        return sum;
    }

    private static void DoEvilPath(int evilPowerRow, int evilPowerCol, int[,] matrix)
    {
        while (evilPowerRow >= 0 && evilPowerCol >= 0)
        {
            if (evilPowerRow >= 0 && evilPowerRow < matrix.GetLength(0) &&
                evilPowerCol >= 0 && evilPowerCol < matrix.GetLength(1))
            {
                matrix[evilPowerRow, evilPowerCol] = 0;
            }
            evilPowerRow--;
            evilPowerCol--;
        }
    }

    private static int[,] GetFilledMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        int value = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = value++;
            }
        }
        return matrix;
    }
}
