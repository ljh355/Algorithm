using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] fristLine = sr.ReadLine().Split(' ');
            
            int n = int.Parse(fristLine[0]);
            int m = int.Parse(fristLine[1]);

            string[] secondLine = sr.ReadLine().Split(' ');

            int[] prefixSum = new int[n + 1];

            // 누적합 배열 제작
            for (int i = 1; i < prefixSum.Length; i++)
            {
                prefixSum[i] += int.Parse(secondLine[i-1]) + prefixSum[i-1];
            }

            for (int i = 0; i < m; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                int count = prefixSum[int.Parse(temp[1])] - prefixSum[int.Parse(temp[0])-1];

                sw.Write(count + "\n");
            }

            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}