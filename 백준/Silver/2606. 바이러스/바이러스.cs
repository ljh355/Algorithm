using System;
using System.Collections.Generic;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int computers = int.Parse(sr.ReadLine());
            int link = int.Parse(sr.ReadLine());

            List<int>[] list = new List<int>[computers + 1];
            bool[] visited = new bool[computers + 1];

            for (int i = 1; i <= computers; i++)
            {
                list[i] = new List<int>();
            }

            for (int i = 0; i < link; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);

                list[a].Add(b);
                list[b].Add(a);
            }

            DFS(1, list, visited);

            int cnt = 0;

            for (int i = 2; i <= computers; i++)
            {
                if (visited[i])
                {
                    cnt++;
                }
            }

            sw.Write(cnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void DFS(int startNode, List<int>[] list, bool[] visited)
        {
            visited[startNode] = true;

            for (int i = 0; i < list[startNode].Count; i++)
            {
                int j = list[startNode][i];
                if (!visited[j])
                {
                    DFS(j, list, visited);
                }
            }
        }
    }
}