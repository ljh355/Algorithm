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

            string[] input = sr.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }

            int counter = 0;

            sb.Append("<");

            while (q.Count > 0)
            {
                counter++;
                if (counter % k == 0)
                {
                    sb.Append(q.Dequeue());

                    if (q.Count > 0)
                    {
                        sb.Append(", ");
                    }
                }
                else
                {
                    q.Enqueue(q.Dequeue());
                }
            }
            sb.Append(">");
            sw.Write(sb + "\n");
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}