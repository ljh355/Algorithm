using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1996
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            int[,] arr = new int[n,n];
            bool[,] mine = new bool[n,n];

            int[] dx = { -1, 1, 0, 0, -1, 1 ,-1, 1 };
            int[] dy = { 0, 0, -1, 1, -1, 1, 1, -1 };

            for (int i = 0; i < n; i++)
            {
                char[] temp = sr.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    if (temp[j] != '.')
                    {
                        int minePoint = temp[j] -'0';
                        arr[i,j] = minePoint;
                        mine[i, j] = true;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (i + dx[k] >= 0 && i + dx[k] < n && 
                            j + dy[k] >= 0 && j + dy[k] < n &&
                            !mine[i + dx[k], j + dy[k]] &&
                            mine[i, j])
                        {
                            arr[i + dx[k], j + dy[k]] += arr[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mine[i, j])
                    {
                        sw.Write('*');
                    }
                    else if (arr[i,j] >= 10)
                    {
                        sw.Write('M');
                    }
                    else
                    {
                        sw.Write(arr[i,j]);
                    }
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}