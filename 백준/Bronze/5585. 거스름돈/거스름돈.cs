using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 5585
            // 1000엔 지폐를 냈을 때, 입력값을 빼고 받는 잔돈 수 구하기
            // 잔돈은 500엔, 100엔, 50엔, 10엔, 5엔, 1엔으로 구성
            // 모든 수가 배수와 약수의 관계를 가지기에 그리디로 해결 가능

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int useMoney = int.Parse(sr.ReadLine());
            int saveMoney = 1000 - useMoney;
            int saveMoneyCnt = 0;

            int[] moneyArr = { 500, 100, 50, 10, 5, 1 };

            for (int i = 0; i < moneyArr.Length; i++)
            {
                saveMoneyCnt += saveMoney / moneyArr[i];
                saveMoney -= (saveMoney / moneyArr[i]) * moneyArr[i];

                if (saveMoney == 0)
                {
                    break;
                }
            }

            sw.Write(saveMoneyCnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}