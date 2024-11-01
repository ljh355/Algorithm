using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 2012
            // n명의 학생에게 자신이 몇 등할지 예상 등수를 제출하게 함
            // 실제 데이터를 날려 각 사람이 제출한 예상 등수를 바탕으로 등수 매김
            // A등 예상했는데 실제 B등이 될 경우, 불만도는 A-B의 절댓값
            // n명의 불만도를 최소한으로 하는 법
            // 정렬한 순서대로 등수 주면 될거같은데
            // 범위, 50만 명 기준이라면 50만 1 * 25만 

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            long n = long.Parse(sr.ReadLine());
            long[] rank = new long[n];

            long result = 0;

            for (int i = 0; i < n; i++)
            {
                rank[i] = long.Parse(sr.ReadLine());
            }

            Array.Sort(rank);

            for (int i = 0; i < n; i++)
            {
                result += Math.Abs((i + 1) - rank[i]);
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}