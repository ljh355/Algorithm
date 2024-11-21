using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1302
            // 중복된 책을 카운트하는 문제
            // 딕셔너리를 사용하면 될 것 같다.

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string bookName = sr.ReadLine();
                if (!dic.ContainsKey(bookName))
                {
                    dic.Add(bookName, 1);
                }
                else
                {
                    dic[bookName]++;
                }
            }

            var mostSellBook = dic
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .FirstOrDefault();

            sw.Write($"{mostSellBook.Key}");
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}