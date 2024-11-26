using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1531

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);

            int[,] arr = new int[101, 101];

            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                int x1 = int.Parse(temp[0]);
                int y1 = int.Parse(temp[1]);
                int x2 = int.Parse(temp[2]);
                int y2 = int.Parse(temp[3]);

                for (int j = x1; j <= x2; j++)
                {
                    for (int k = y1; k <= y2; k++)
                    {
                        arr[j, k]++;
                    }
                }
            }

            int result = 0;

            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    if (arr[i, j] > m)
                    {
                        result++;
                    }
                }
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}