using System;
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

            string[] size = sr.ReadLine().Split(' ');

            string[] temp = sr.ReadLine().Split(' ');

            int t = int.Parse(temp[0]);
            int p = int.Parse(temp[1]);

            int tCount = 0;

            // 티셔츠 최소 묶음
            for (int i = 0; i < size.Length; i++)
            {
                int tSize = int.Parse(size[i]);
                tCount += (tSize+t-1)/t;
            }

            sb.Append(tCount + "\n" + n/p + " " + n%p);
            sw.Write(sb + "\n");
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}