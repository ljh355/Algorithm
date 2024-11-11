using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static int result = 0;
        static void Main()
        {
            // 백준 1074
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int r = int.Parse(firstLine[1]);
            int c = int.Parse(firstLine[2]);
            int lastPoint = (int)Math.Pow(2, n) * (int)Math.Pow(2, n) - 1;

            Z(n, r+1, c+1, 0, lastPoint); // 계산상 편의를 위해 1씩 더해줌

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void Z(int n, int r, int c, int start, int end)
        {
            if (n == 1)
            {
                result = start;
                if (r == 2) result += 2;
                if (c == 2) result += 1;
                return;
            }

            int cut = (int)Math.Pow(2, n-1);

            // n=3이면 8x8판이므로 4등분시 n=2 4x4 = 16칸짜리 판으로 나뉜다.
            // 1사분면 (우측 상단) -> 
            // 2사분면 (좌측 상단) -> end 지점만 바뀐다
            // 3사분면 (좌측 하단) -> 
            // 4사분면 (우측 하단) -> start 지점만 바뀐다
            // 2^3 기준으로 64칸이다. 2^2(n-1)칸마다 사분면이 바뀐다.

            if (r > cut && c > cut) // 우측 하단
            {
                r -= cut;
                c -= cut;
                start = (end + 1) - cut * cut;
            }
            else if (r > cut) // 좌측 하단
            {
                r -= cut;
                start = start + cut * cut * 2;
                end = (start - 1) + cut * cut;
            }
            else if (c > cut) // 우측 상단
            {
                c -= cut;
                start = start + cut * cut;
                end = (start - 1) + cut * cut;
            }
            else // 좌측 상단
            {
                end = (start - 1) + cut * cut;
            }

            Z(n - 1, r, c, start, end);
        }
    }
}