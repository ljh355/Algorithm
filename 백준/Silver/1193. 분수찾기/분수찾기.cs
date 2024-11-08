using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1193
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int x = int.Parse(sr.ReadLine());

            // 1 2 3 4 5 6 7 ... 마다 사이클이 돈다
            // 1 3 6 10 15 21 28 ... 이라고 볼 수 있음

            // [1] [2] [3] [4] [5] [6] [7] [8]
            // 1-1 1-2 2-1 3-1 2-2 1-3 1-4 2-3 
            //  1   2   2   3   3   3   4   4
            // 1-1 1-2 3-1 1-4

            int save = x;

            int k = 0; // 최대범위

            int cnt = 0;

            while (x > 0)
            {
                cnt++;
                x -= cnt;
                k += cnt;
            }

            // 8(save)의 경우 4번의 카운트 첫번째 인덱스는 7(k-cnt)
            // 그 차이만큼 cnt 부분이 줄어들고, 1부분이 늘어난다.
            // 분모 : 1 + cnt - (save - (k-cnt));
            // 분자 : 1 + (save - (k-cnt));
            // 3(save)의 경우 2번의 카운트 첫번째 인덱스는 1(k-cnt)
            // 2 - ( 3 - (-2))

            cnt--;

            int a = 1 - save + k; // 분모
            int b = 1 + save - k + cnt; // 분자

            if (cnt % 2 == 0) // 스왑
            {
                b = 1 + - save + k;
                a = 1 + save - k + cnt;
            }

            sw.Write(b + "/" + a);

            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}