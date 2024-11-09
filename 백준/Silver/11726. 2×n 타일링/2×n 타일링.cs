using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static int[] memo = new int[1001];
        static void Main()
        {
            // 백준 11726
            // 2xn 크기의 직사각형을 1x2, 2x1로 채우는 방법의 수를 10007로 나눈 나머지 출력
            // 1 <= n <= 1000
            // 엄청 케이스가 많아질 수 있으므로 dp로 계산

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            // 2x1 -> 1개
            // 2x2 -> 2개
            // 2x3 -> 3개
            // 2x4 -> 5개
            // 8 13 21 34 55
            // dp(n) = dp(n-1) + dp(n-2)
            // 피보나치 수열과 동일한 원리
            // 메모이제이션을 통해 시간복잡도 관리
            
            sw.Write(dp(n));
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int dp(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (memo[n] != 0) return memo[n];

            memo[n] = (dp(n-1) + dp(n-2)) % 10007;

            return memo[n];
        }
    }
}