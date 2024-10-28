using System;
using System.IO;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] input = sr.ReadLine().Split(' ');
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            int[] arr = new int[n + 1];

            for (int i = 2; i <= n; i++)
            {
                arr[i] = i;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }

                for (int j = i*i; j <= n; j += i)
                {
                    arr[j] = 0;
                }
            }

            for (int i = m; i <= n; i++)
            {
                if (arr[i] != 0)
                {
                    sb.Append(arr[i] + "\n");
                }
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}