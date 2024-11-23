using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1449

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');
            string[] secondLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]);
            int l = int.Parse(firstLine[1]);

            int[] arr = new int[n];

            for (int i = 0 ; i < n; i++)
            {
                arr[i] = int.Parse(secondLine[i]);
            }

            Array.Sort(arr);

            int keepIndex = arr[0] + l - 1;

            int result = 1;

            for (int i = 1; i < n; i++)
            {
                int checkNum = arr[i];

                if (keepIndex >= checkNum)
                {
                    continue;
                }
                else
                {
                    keepIndex = checkNum + l - 1;
                    result++;
                }
                
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}