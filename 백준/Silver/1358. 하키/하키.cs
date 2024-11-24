using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1358

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            int w = int.Parse(firstLine[0]);
            int h = int.Parse(firstLine[1]);
            int x = int.Parse(firstLine[2]);
            int y = int.Parse(firstLine[3]);
            int p = int.Parse(firstLine[4]);

            // (x, y+radius), (x+w, y+radius) 2개의 원 범위 포함을 확인
            // 동시에 (x,y)와 (x+w, y+h)의 직사각형 범위도 포함을 확인해야함

            int result = 0;

            for (int i = 0; i < p; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);

                result += CalHockeyPlayer(w, h, x, y, a, b);
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int CalHockeyPlayer(int w, int h, int x, int y, int a, int b)
        {
            int radius = h / 2;
            int leftX = x;
            int leftY = y + radius;
            int rightX = x + w;
            int rightY = y + radius;

            int cnt = 0;

            int leftDistance = (a - leftX) * (a - leftX) + (b - leftY) * (b - leftY);
            int rightDistance = (a - rightX) * (a - rightX) + (b - rightY) * (b - rightY);
            int radiusSqrt = radius * radius;

            if (leftDistance <= radiusSqrt) // 왼쪽 원 범위 검증
            {
                cnt++;
            }
            else if (rightDistance <= radiusSqrt) // 오른쪽 원 범위 검증
            {
                cnt++;
            }
            else if (a >= x && b >= y && a <= x+w && b <= y+h) // 직사각형 범위 검증
            {
                cnt++;
            }

            return cnt;
        }
    }
}