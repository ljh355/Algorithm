using System;
using System.IO;
using System.Text;
using System.Numerics;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1010
            // 조합 문제
            // n! / (n-r)!r!
            // 단, 범위가 30까지인 점이 중요
            // int는 12!, long은 20!까지 계산 가능
            // 미리 계산을 하는 방식을 사용하거나 BigInteger 사용으로 해결이 필요

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(sr.ReadLine());

            for (int i=0; i<t; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                int n = int.Parse(temp[0]);
                int m = int.Parse(temp[1]);

                BigInteger bridgeCase = Factorial(m) / (Factorial(m-n)*Factorial(n));

                sb.AppendLine($"{bridgeCase}");
            }


            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static BigInteger Factorial(int num)
        {
            BigInteger result = 1;
            for (int i=2; i<=num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}