using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1932
            // dp문제

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            int[,] arr = new int[n, n];

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                for (int j = 0; j < temp.Length; j++)
                {
                    arr[i, j] = int.Parse(temp[j]);
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) // 첫 위치는 대각선이 하나
                    {
                        arr[i, j] += arr[i - 1, 0];
                    }
                    else if (j == i) // 마지막 위치도 대각선이 하나
                    {
                        arr[i, j] += arr[i - 1, i - 1];
                    }
                    else // 그 외에는 왼쪽과 본인 위와 체크해서
                    {
                        arr[i, j] += Math.Max(arr[i - 1, j - 1], arr[i - 1, j]);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                result = Math.Max(result, arr[n-1, i]);
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}