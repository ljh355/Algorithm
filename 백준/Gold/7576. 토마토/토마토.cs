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
            int m = int.Parse(firstLine[0]);
            int n = int.Parse(firstLine[1]);

            int[,] map = new int[n, m];
            Queue<(int, int)> ripeTomato = new Queue<(int, int)> ();
            int notRipeTomato = 0;

            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    map[i,j] = int.Parse(temp[j]);

                    if (map[i, j] == 1)
                    {
                        ripeTomato.Enqueue((i, j));
                    }
                    else if (map[i, j] == 0)
                    {
                        notRipeTomato++;
                    }
                }
            }

            sb.Append(BFS(map, ripeTomato, n, m, notRipeTomato));

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int BFS(int[,] map, Queue<(int, int)> ripeTomato, int n, int m, int notRipeTomato)
        {
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            int days = 0;

            while (ripeTomato.Count > 0)
            {
                // 반복하는 횟수는 큐에 담겨져 있는만큼
                int size = ripeTomato.Count;

                for (int i = 0; i < size; i++)
                {
                    (int x, int y) = ripeTomato.Dequeue();
                    for (int d = 0; d < 4; d++)
                    {
                        int newX = x + dx[d];
                        int newY = y + dy[d];

                        if (newX >= 0 && newY >= 0 && newX < n && newY < m && map[newX, newY] == 0)
                        {
                            map[newX, newY] = 1;
                            ripeTomato.Enqueue((newX, newY));
                            notRipeTomato--;
                        }
                    }
                }
                days++;
            }

            if (notRipeTomato > 0)
            {
                return -1;
            }
            else
            {
                return days == 0 ? 0 : days - 1;
            }
        }
    }
}