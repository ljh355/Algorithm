using System;
using System.IO;
using System.Collections.Generic;

namespace codingTest
{
    internal class Program
    {
        static bool[] visited;
        static int result = 0;
        static void Main()
        {
            // 백준 1697
            // 수빈이는 n, 동생은 k에 있다
            // 수빈이의 현재 위치는 x
            // 걷는다면 1초 후, x-1 또는 x+1로 이동
            // 순간이동한다면 1초 후, 2*x로 이동
            // 수빈이가 동생을 찾을 수 있는 가장 빠른 시간

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);

            // 5 -> 17로 이동하는 예제
            // 5 -> 10 -> 9 -> 18 -> 17
            // 0부터 10만까지의 무방향 그래프라고 가정하고
            // bfs를 실행해서 가장 낮은 숫자를 출력

            visited = new bool[100001];

            BFS(n, k);

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void BFS(int n, int k)
        {
            Queue<(int,int)> q = new Queue<(int,int)>();
            var (start, cnt) = (n, 0);
            q.Enqueue((start, cnt));
            visited[n] = true;

            while(q.Count > 0)
            {
                var (x, y) = q.Dequeue();

                if (x==k)
                {
                    result = y;
                    return;
                }

                if (x-1>=0 && !visited[x-1])
                {
                    visited[x-1] = true;
                    q.Enqueue((x-1, y+1));
                }

                if (x+1<=100000 && !visited[x+1])
                {
                    visited[x+1] = true;
                    q.Enqueue((x+1, y+1));
                }
                
                if (x*2<=100000 && !visited[x*2])
                {
                    visited[x*2] = true;
                    q.Enqueue((x*2, y+1));
                }
            }
        }
    }
}