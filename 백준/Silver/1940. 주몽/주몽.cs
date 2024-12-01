using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1940

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            int m = int.Parse(sr.ReadLine());

            int result = 0;

            string[] temp = sr.ReadLine().Split(' ');

            int[] arr = Array.ConvertAll(temp, int.Parse);

            Array.Sort(arr);

            // n-1번만큼 반복

            int startIndex = 0;
            int endIndex = n - 1;

            for (int i = 0; i < n - 1; i++)
            {
                int materialSum = arr[startIndex] + arr[endIndex];

                if (materialSum > m)
                {
                    endIndex--;
                }
                else if (materialSum < m)
                {
                    startIndex++;
                }
                else
                {
                    startIndex++;
                    endIndex--;
                    result++;
                }

                if (startIndex >= endIndex) break;
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}