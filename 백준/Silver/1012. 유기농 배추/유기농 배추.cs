using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };
        static int m;
        static int n;

        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(sr.ReadLine());

            for (int tc = 0; tc < t; tc++)
            {
                string[] secendLine = sr.ReadLine().Split(' ');

                m = int.Parse(secendLine[0]); // 가로길이
                n = int.Parse(secendLine[1]); // 세로길이
                int k = int.Parse(secendLine[2]); // 배추 수

                int[,] map = new int[m, n];
                bool[,] visited = new bool[m, n];

                for (int i = 0; i < k; i++)
                {
                    string[] temp = sr.ReadLine().Split(' ');

                    int a = int.Parse(temp[0]);
                    int b = int.Parse(temp[1]);

                    map[a, b] = 1;
                }

                int wormCnt = 0;

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (map[i, j] == 1 && !visited[i, j])
                        {
                            BFS(i, j, map, visited);
                            wormCnt++;
                        }
                    }
                }
                sb.Append(wormCnt + "\n");
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void BFS(int x, int y, int[,] map, bool[,] visited)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((x, y));
            visited[x, y] = true;

            while (q.Count > 0)
            {
                (int curX, int curY) = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nx = curX + dx[i];
                    int ny = curY + dy[i];

                    if (nx >= 0 && nx < m && ny >= 0 && ny < n)
                    {
                        if (map[nx, ny] == 1 && !visited[nx, ny])
                        {
                            q.Enqueue((nx, ny));
                            visited[nx, ny] = true;
                        }
                    }
                }
            }
        }
    }
}