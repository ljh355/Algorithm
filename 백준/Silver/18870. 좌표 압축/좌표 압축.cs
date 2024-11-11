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
            // 백준 18870
            // 크기가 작은 순서대로 좌표값을 압축하는 것
            // 딕셔너리를 이용하면 될듯 생각했는데 생각보다 복잡해지는 느낌
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            int[] x = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < x.Length; i++)
            {
                dic.Add(i, x[i]);
            }

            var sortedByValue = dic.OrderBy(item => item.Value).ToDictionary(a => a.Key, a => a.Value);

            // (0,2) (1,4) (2,-10) (3, 4) (4, -9)
            // (2,-10) (4, -9) (0,2) (1,4) (3, 4)
            // (2, 0) (4, 1) (0, 2) (1, 3) (3, 3)

            int rank = 0;
            int temp = Int32.MaxValue;

            Dictionary<int, int> rankDic = new Dictionary<int, int>();

            foreach(var key in sortedByValue.Keys)
            {
                if (temp == sortedByValue[key])
                {
                    rank--;
                }
                temp = sortedByValue[key];
                rankDic[key] = rank;
                rank++;
            }

            var sortedByRank = rankDic.OrderBy(item => item.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var key in sortedByRank.Values)
            {
                sb.Append(key.ToString() + " ");
            }

            sb.Length--;

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}