using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1748

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string n = sr.ReadLine();
            int intN = int.Parse(n);

            // 1~9까지는 나열하는게 하나씩 카운트
            // 10~99까지는 나열하는게 두개씩 카운트
            // 즉, 120이라는 숫자가 나온다면 21*3 + 90*2 + 9*1 = 252
            // 최대 1억까지 가능하기에 9까지 카운트 가능
            // 9천만 * 8 + 900만 * 7 + 90만 * 6 .. = 8억이 넘지 않으므로 int

            int nLength = n.Length;

            int temp = 1;

            for (int i = 1; i < nLength; i++)
            {
                temp *= 10;
            }

            intN = (intN + 1 - temp) * nLength;
            nLength--;

            while (nLength > 0)
            {
                temp /= 10;
                intN += (temp * 10 - temp) * nLength;
                nLength--;
            }

            sw.Write(intN);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}