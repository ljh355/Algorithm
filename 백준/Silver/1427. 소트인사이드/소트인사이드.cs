using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1427

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string n = sr.ReadLine();

            int[] a = n.Select(c => int.Parse(c.ToString())).ToArray();

            Array.Sort(a);

            for (int i = a.Length - 1; i >= 0; i--)
            {
                sb.Append(a[i]);
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}