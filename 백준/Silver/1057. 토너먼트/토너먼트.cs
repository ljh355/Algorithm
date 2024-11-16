using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1057
            // 1번부터 N번까지의 참가자는 인접한 번호끼리 스타를 한다.
            // 토너먼트를 진행, 홀수인 경우 마지막 번호가 자동 진출
            // 김지민과 임한수가 몇 라운드에 대결하는가
            // 각 번호를 2로 나눈 값이 같아질 때까지 반복하면 확인 가능
            // 단, 나눈 값이 1.5인 경우에는 높임 처리 필요

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] input = sr.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int kjmNum = int.Parse(input[1]);
            int ihsNum = int.Parse(input[2]);

            int result = 0;

            while (kjmNum != ihsNum)
            {
                kjmNum = (int)Math.Ceiling((double)kjmNum / 2);
                ihsNum = (int)Math.Ceiling((double)ihsNum / 2);
                result++;
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}