using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1065
            // 1 <= n <= 1000 범위에 있는 n이 등차수열인 경우를 세는 것
            // 숫자가 1~99까지는 모두 등차수열이라고 볼 수 있다.
            // 따라서 ~99까지는 카운팅을 하고 세자리수에서만 판별하면 됨

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            int result = 0;

            if (n >= 100)
            {
                result = 99;
            }
            else
            {
                result = n;
            }

            while (n > 100)
            {
                if (n == 1000) n--; // 1000은 한수가 아니므로 아래 계산 적용을 위해 하나 빼줌
                int hundredNum = (n / 100) % 10; // 백의 자리
                int tenNum = (n / 10) % 10; // 십의 자리
                int oneNum = n % 10; // 일의 자리

                if (hundredNum - tenNum == tenNum - oneNum)
                {
                    result++;
                }
                n--;
            }

            sw.Write(result);

            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}