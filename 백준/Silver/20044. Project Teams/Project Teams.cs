using System;
using System.Collections.Generic;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 20044
            // 프로젝트 팀 하나는 두 명의 학생, 최대한 비슷하게
            // sort를 통해 시작점과 끝점부터 좁혀오며 계산

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            int[] w = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[] team = new int[n];

            int result = 0;

            Array.Sort(w);

            for (int i = 0; i < n; i++)
            {
                team[i] = w[i] + w[w.Length - 1 - i];
            }

            result = team[0];

            for (int i = 1; i < n; i++)
            {
                if (result > team[i])
                {
                    result = team[i];
                }
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}