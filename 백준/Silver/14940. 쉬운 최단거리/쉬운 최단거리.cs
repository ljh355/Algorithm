using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] firstLine = sr.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);

            int[,] map = new int[n, m];
            int[,] distance = new int[n, m];
            int startX = -1, startY = -1;
            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    map[i,j] = int.Parse(temp[j]);
                    distance[i, j] = -1;

                    if (map[i,j] == 2)
                    {
                        startX = i;
                        startY = j;
                    }
                }
            }

            BFS(map, distance, startX, startY);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (map[i,j] == 0)
                    {
                        sb.Append(0 + " ");
                    }
                    else
                    {
                        sb.Append(distance[i, j] + " ");
                    }
                }
                sb.Append("\n");
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void BFS(int[,] map, int[,] distance, int startX, int startY)
        {
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            Queue<(int, int)> q = new Queue<(int, int)> ();
            q.Enqueue((startX, startY));
            distance[startX, startY] = 0;

            while (q.Count > 0)
            {
                (int x, int y) = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];

                    if (newX >= 0 && newY >= 0 && newX < map.GetLength(0) && newY < map.GetLength(1))
                    {
                        if (map[newX, newY] == 1 && distance[newX, newY] == -1)
                        {
                            distance[newX, newY] = distance[x, y] + 1;
                            q.Enqueue((newX, newY));
                        }
                    }
                }
            }
        }
    }
}