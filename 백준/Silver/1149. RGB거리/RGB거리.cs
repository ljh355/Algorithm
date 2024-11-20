using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1149
            // 1번부터 n번 집이 순서대로 있고, 거리는 선분으로 나타낼 수 있다
            // 빨 초 파 중 하나로 칠하고, 비용이 주어질 때 아래 규칙을 만족하는 최솟값
            // 1번 집은 2번 집의 색과 같지 않아야 한다.
            // n번 집은 n-1번 집의 색과 같지 않아야 한다.
            // i(2 <= i <= n-1)번 집의 색은 i-1, i+1번 집의 색과 같지 않아야 한다.

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            int[,] arr = new int[n+1, 3];

            for (int i = 1; i <= n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                int one = int.Parse(temp[0]);
                int two = int.Parse(temp[1]);
                int three = int.Parse(temp[2]);

                arr[i, 0] = one + Math.Min(arr[i - 1, 1], arr[i - 1, 2]);
                arr[i, 1] = two + Math.Min(arr[i - 1, 0], arr[i - 1, 2]);
                arr[i, 2] = three + Math.Min(arr[i - 1, 0], arr[i - 1, 1]);
            }

            int result = Math.Min(Math.Min(arr[n, 0], arr[n, 1]), arr[n, 2]);

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}