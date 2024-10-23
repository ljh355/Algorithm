using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);

            string[] board = new string[n];

            for (int i = 0; i < n; i++)
            {
                board[i] = sr.ReadLine();
            }

            int result = int.MaxValue;

            for (int i = 0; i <= n - 8; i++)
            {
                for (int j = 0; j <= m - 8; j++)
                {
                    int curResult = CalChess(i, j, board);

                    if (result > curResult)
                    {
                        result = curResult;
                    }
                }
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int CalChess(int startRow, int startCol, string[] board)
        {
            string[] whiteBoard = { "WBWBWBWB", "BWBWBWBW" };
            int whiteCnt = 0;

            for (int i = 0; i < 8; i++)
            {
                int row = startRow + i;
                for(int j = 0; j < 8; j++)
                {
                    int col = startCol + j;

                    if (board[row][col] != whiteBoard[row % 2][j])
                    {
                        whiteCnt++;
                    }
                }
            }

            return Math.Min(whiteCnt, 64 - whiteCnt);
        }
    }
}