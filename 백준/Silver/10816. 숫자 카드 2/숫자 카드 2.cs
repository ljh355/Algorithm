using System;
using System.Collections.Generic;
using System.IO;
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

            int n = int.Parse(sr.ReadLine()); // 첫째 줄 입력

            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] cardArr = sr.ReadLine().Split(' '); // 둘째 줄 입력

            for (int i = 0; i < n; i++)
            {
                if (dic.ContainsKey(cardArr[i]))
                {
                    dic[cardArr[i]]++;
                }
                else
                {
                    dic.Add(cardArr[i], 1);
                }
            }

            int m = int.Parse(sr.ReadLine()); // 셋째 줄 입력

            string[] sgArr = sr.ReadLine().Split(' '); // 넷째 줄 입력
            
            for (int i = 0;i < m; i++)
            {
                // dic에서 key가 있다면 value, 없으면 0으로 저장
                if(dic.TryGetValue(sgArr[i], out n))
                {
                    // 해당 value sb에 저장
                    sb.Append(n);
                }
                else
                {
                    sb.Append(0);
                }
                sb.Append(' ');
            }
            sb.Append('\n');
            
            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}