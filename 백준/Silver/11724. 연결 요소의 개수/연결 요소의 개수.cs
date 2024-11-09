using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 11724
            // 무방향 그래프의 연결 요소 개수를 세는 문제
            // DFS나 BFS를 통해서 해결 가능
            // 이차원 배열이나 인접 리스트 등에 담아 해결

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int result = 0;

            string[] firstLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);

            int[,] arr = new int[n+1,n+1];
            bool[] visited = new bool[n+1];

            for (int i=0; i<m; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                int u = int.Parse(temp[0]);
                int v = int.Parse(temp[1]);

                arr[u,v] = 1;
                arr[v,u] = 1; 
            }

            for (int i=1; i<=n; i++)
            {
                if (!visited[i])
                {
                    DFS(i, arr, visited);
                    result++;
                }
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void DFS(int checkNum, int[,] arr, bool[] visited)
        {
            visited[checkNum] = true;

            for (int i=1; i<visited.Length; i++)
            {
                if (arr[checkNum, i] == 1 && !visited[i])
                {
                    DFS(i, arr, visited);
                }
            }
        }
    }
}