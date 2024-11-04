using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // Math.Pow해서 while문 돌리면 시간초과
            // Math.Pow의 경우, O(log y)의 시간복잡도
            // 이 때, y는 비트 수에 비례한다.
            // 비트 시프트를 통해 바꿔서 해결

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int x = int.Parse(sr.ReadLine());

            int result = 0;

            for (int i = 0; i < 7; i++)
            {
                if ((x & (1 << i)) != 0)
                {
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