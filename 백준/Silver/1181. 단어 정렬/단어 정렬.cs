using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());

            List<string> word = new List<string>();

            for (int i = 0; i < n; i++)
            {
                word.Add(sr.ReadLine());
            }

            word = word.Distinct().ToList(); // 중복제거

            // 정렬 순서는 1. 길이, 2. 사전순
            word.Sort((x, y) =>
            {
                int wordLength = x.Length.CompareTo(y.Length); // 길이 비교
                if (wordLength == 0)
                {
                    return x.CompareTo(y); // 사전순 비교
                }
                return wordLength;
            });

            foreach (var number in word)
            {
                sb.AppendLine(number);
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}