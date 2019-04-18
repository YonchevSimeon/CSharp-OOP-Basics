using System;

namespace P06_Sneaking
{
    class Sneaking
    {
        static char[][] room;
        static void Main()
        {
            int matrixRows = int.Parse(Console.ReadLine());

            GetRoom(matrixRows);

            char[] samMoves = Console.ReadLine().ToCharArray();

            int[] samPosition = GetSamPosition();
            
            for (int i = 0; i < samMoves.Length; i++)
            {
                MoveEnemies();

                int[] enemyPosition = GetEnemyPosition(samPosition);

                CheckIfSamIsGoingToDie(samPosition, enemyPosition);
               
                room[samPosition[0]][samPosition[1]] = '.';
                switch (samMoves[i])
                {
                    case 'U':
                        samPosition[0]--;
                        break;
                    case 'D':
                        samPosition[0]++;
                        break;
                    case 'L':
                        samPosition[1]--;
                        break;
                    case 'R':
                        samPosition[1]++;
                        break;
                    default:
                        break;
                }
                room[samPosition[0]][samPosition[1]] = 'S';

                enemyPosition = GetEnemyPosition(samPosition);

                CheckIfSamWins(samPosition, enemyPosition);   
            }
        }

        private static void CheckIfSamIsGoingToDie(int[] samPosition, int[] enemyPosition)
        {
            if (samPosition[1] < enemyPosition[1] && room[enemyPosition[0]][enemyPosition[1]] == 'd' &&
                    enemyPosition[0] == samPosition[0])
            {
                room[samPosition[0]][samPosition[1]] = 'X';
                Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
                PrintRoom();
                Environment.Exit(0);
            }
            else if (enemyPosition[1] < samPosition[1] && room[enemyPosition[0]][enemyPosition[1]] == 'b' &&
                     enemyPosition[0] == samPosition[0])
            {
                room[samPosition[0]][samPosition[1]] = 'X';
                Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");

                PrintRoom();
                Environment.Exit(0);
            }
        }

        private static void CheckIfSamWins(int[] samPosition, int[] enemyPosition)
        {
            if (room[enemyPosition[0]][enemyPosition[1]] == 'N' && samPosition[0] == enemyPosition[0])
            {
                room[enemyPosition[0]][enemyPosition[1]] = 'X';
                Console.WriteLine("Nikoladze killed!");
                PrintRoom();
                Environment.Exit(0);
            }
        }

        private static int[] GetEnemyPosition(int[] samPosition)
        {
            int[] enemyPosition = new int[2];
            for (int col = 0; col < room[samPosition[0]].Length; col++)
            {
                if (room[samPosition[0]][col] != '.' && room[samPosition[0]][col] != 'S')
                {
                    enemyPosition[0] = samPosition[0];
                    enemyPosition[1] = col;
                }
            }
            return enemyPosition;
        }

        private static void MoveEnemies()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private static int[] GetSamPosition()
        {
            int[] samPosition = new int[2];
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;
                    }
                }
            }
            return samPosition;
        }

        private static void GetRoom(int matrixRows)
        {
            room = new char[matrixRows][];
            for (int row = 0; row < matrixRows; row++)
            {
                room[row] = Console.ReadLine().ToCharArray();
            }
        }

        private static void PrintRoom()
        {
            foreach (char[] row in room)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
