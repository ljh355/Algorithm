using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1459
            // 도시의 세로 도로는 x좌표, 가로 도로는 y좌표.
            // 현재 (0,0) -> (x, y)로 가려고 한다.
            // 도로를 따라 가거나, 블록을 대각선으로 가로지를 수 있다.
            // 최소시간이 얼마인가?

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            long[] input = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse);

            long x = input[0];
            long y = input[1];
            long w = input[2]; // 한 블록 가는데 걸리는 시간
            long s = input[3]; // 대각선으로 한 블록 가로지르는 시간

            long max = Math.Max(x, y);
            long min = Math.Min(x, y);
            long result = 0;

            // 기본 조건 : 가로(w)+세로(w)가 대각선(s)과 같다.
            // 1. 2w <= s, 종횡 이동으로만 값 처리
            // 2. 대각선으로만 가면서 처리, 
            // 3. 대각선으로 갔다가 종횡 이동해서 처리

            // (0,1), (1,0)은 무조건 종횡 이동해야함
            // (0,2)는 x+y종횡 or y대각
            // (0,3)는 x+y종횡 or y-1대각+1종횡 or x대각+(y-x)종횡
            // (0,4)는 (0,2)와 동일
            // (0,5)는 (0,3)과 동일

            // (1,1)은 x+y종횡이나 y대각
            // (1,2)는 x+y종횡 or y-1대각+1종횡 or x대각+(y-x)종횡
            // (1,3)은 x+y종횡 or y대각 or x대각+(y-x)종횡

            // (2,3)은 x+y종횡 or y-1대각+1종횡 or x대각+(y-x)종횡
            // (2,4)는 x+y종횡 or y대각 

            // (2,5)는 x+y종횡 or y-1대각+1종횡 or x대각+(y-x)종횡

            // 해당 규칙에 따라 x+y의 값이 홀수라면 x+y종횡, y-1대각+1종횡, x대각+(y-x)종횡
            // x+y의 값이 짝수라면 x+y종횡과 y대각, x대각+(y-x)종횡 중 작은 것
            // 이 때, y가 max, x가 min에 매칭된다.
            // 또한, 범위가 크기에 long으로 설정

            if ((min + max) % 2 != 0)
            {
                result = Math.Min(Math.Min((min + max) * w, (max - 1) * s + w), min * s + (max - min) * w);
            }
            else
            {
                result = Math.Min(Math.Min((min + max) * w, max * s), min * s + (max - min) * w);
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}