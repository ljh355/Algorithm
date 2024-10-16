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

            int tc = int.Parse(sr.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                Dictionary<string, int> dic = new Dictionary<string, int>();
                int result = 1;
                int n = int.Parse(sr.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    string[] strTemp = sr.ReadLine().Split(' ');

                    if (dic.ContainsKey(strTemp[1]))
                    {
                        dic[strTemp[1]]++;
                    }
                    else
                    {
                        dic.Add(strTemp[1], 1);
                    } 
                }

                foreach (var val in dic.Values)
                {
                    result *= (val + 1);
                }
                sb.Append(result - 1 + "\n");
            }
            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}