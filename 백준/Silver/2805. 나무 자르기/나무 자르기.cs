using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 2805
            // 나무의 수 n, 가져갈 나무의 길이 m
            // 절단기를 어느 기준으로 놓아야 가장 높은가
            // 동빈나 영상의 이분 탐색 문제와 동일

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);

            int[] tree = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(tree);

            int startHigh = 0;
            int endHigh = tree[n-1];
            int midHigh = 0;
            long cutSum = 0;

            // 10 15 17 20일 경우,
            // 시작점 0, 끝점 20 기준으로 중간점 10 설정
            // 0 5 7 10 = 22가 자른 높이의 합
            // 가져갈 양은 7
            // 더 잘라야하므로 시작점 = 중간점 설정
            // 시작점 10, 끝점 20 , 중간점 15

            while(true)
            {
                midHigh = (startHigh+endHigh)/2;
                cutSum = 0;

               if (startHigh > endHigh)
                {
                    break;
                }

                for (int i=0; i<n; i++)
                {
                    if (tree[i] - midHigh > 0)
                    {
                        cutSum += (long)(tree[i] - midHigh);
                    }
                }

                if (m == cutSum) break;
                else if (m > cutSum) endHigh = midHigh-1;
                else startHigh = midHigh+1;
            }

            sw.Write(midHigh);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}