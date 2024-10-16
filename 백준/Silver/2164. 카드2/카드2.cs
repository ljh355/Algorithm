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

            int n = int.Parse(sr.ReadLine());

            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }

            while (q.Count > 1)
            {
                q.Dequeue();
                q.Enqueue(q.Dequeue());
            }

            sb.Append(q.Peek()+"\n");
            
            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}